using AutoCADAPI.Lab2;
using AutoCADAPI.Lab3.Model;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;

namespace AutoCADAPI.Lab3
{
    /// <summary>
    /// Realizá la prueba de contacto de las compuertas
    /// </summary>
    public class TestCommands
    {
        /// <summary>
        /// Las compuertas insertadas en el plano
        /// </summary>
        Dictionary<Handle, Compuerta> Compuertas;
        /// <summary>
        /// Define un comando que prueba la inserción de una compuerta
        /// </summary>
        [CommandMethod("TestInsertCompuerta")]
        public void InsertCompuerta()
        {
            if (Compuertas == null)
                Compuertas = new Dictionary<Handle, Compuerta>();
            Point3d pt;
            if (Selector.Point("Selecciona el punto de inserción de la compuerta", out pt))
            {
                TransactionWrapper tr = new TransactionWrapper();
                var cmp = tr.Run(InsertCompuertaTask, new AND(), pt) as Compuerta;
                Compuertas.Add(cmp.Id, cmp);
            }
        }
        /// <summary>
        /// Define la transacción que inserta una compuerta
        /// </summary>
        /// <param name="doc">El documento activo.</param>
        /// <param name="tr">La transacción activa.</param>
        /// <param name="input">La entrada de la transacción.</param>
        /// <returns>La compuerta insertada</returns>
        private object InsertCompuertaTask(Document doc, Transaction tr, object[] input)
        {
            Compuerta cmp = (Compuerta)input[0];
            Point3d pt = (Point3d)input[1];
            cmp.Insert(pt, tr, doc);
            return cmp;
        }
        /// <summary>
        /// Realiza la prueba de contacto de la compuerta
        /// </summary>
        [CommandMethod("TestZone")]
        public void TestZone()
        {
            Point3d test_pt;
            ObjectId pickEnt;
            if (Selector.Entity("Selecciona una compuerta", out pickEnt, out test_pt))
            {
                //Buscamos la compuerta por ObjectId
                Compuerta cmp = this.Compuertas.Values.FirstOrDefault(x => x.Block.Id == pickEnt);
                Editor ed = Application.DocumentManager.MdiActiveDocument.Editor;
                if (cmp != null)
                {
                    TransactionWrapper t = new TransactionWrapper();
                    //Se dibujan las zonas
                    ObjectIdCollection ids = t.Run(DrawZonesTask, cmp) as ObjectIdCollection;
                    ed.Regen();
                    //Se realizan las pruebas de contacto
                    t.Run(TestZoneTask, cmp);
                    //Se eliminan los rectangulos dibujados de la zona
                    t.Run(EraseZonesTask, ids);

                }
                else
                    ed.WriteMessage("No es una compuerta");
            }
        }
        /// <summary>
        /// Define la transacción que dibuja las áreas de contacto de la compuerta
        /// No es necesario que sean visibles para realizar la prueba.
        /// </summary>
        /// <param name="doc">El documento activo.</param>
        /// <param name="tr">La transacción activa.</param>
        /// <param name="input">La entrada de la transacción.</param>
        /// <returns>La compuerta insertada</returns>
        private object DrawZonesTask(Document doc, Transaction tr, object[] input)
        {
            Compuerta cmp = (Compuerta)input[0];
            Drawer d = new Drawer(tr);
            cmp.InitBox();
            cmp.DrawBox(d);
            return d.Ids;
        }
        /// <summary>
        /// Borra las zonas dibujadas
        /// </summary>
        /// <param name="doc">El documento activo.</param>
        /// <param name="tr">La transacción activa.</param>
        /// <param name="input">La entrada de la transacción.</param>
        private object EraseZonesTask(Document doc, Transaction tr, object[] input)
        {
            ObjectIdCollection ids = input[0] as ObjectIdCollection;
            Drawer d = new Drawer(tr);
            d.Erase(ids);
            return null;
        }
        /// <summary>
        /// Define la transacción que prueba la zona de contacto de la compuerta
        /// </summary>
        /// <param name="doc">El documento activo.</param>
        /// <param name="tr">La transacción activa.</param>
        /// <param name="input">La entrada de la transacción.</param>
        /// <returns>La compuerta insertada</returns>
        private object TestZoneTask(Document doc, Transaction tr, object[] input)
        {
            Compuerta cmp = (Compuerta)input[0];
            Point3d test_pt;
            Editor ed = doc.Editor;
            while (Selector.Point("Selecciona una zona de contacto", out test_pt, true))
            {
                string zoneName;
                Point3dCollection zone;
                cmp.GetZone(test_pt, out zoneName, out zone);
                if (zoneName == String.Empty)
                    ed.WriteMessage("\nPunto fuera de la zona");
                else
                {
                    String coords = string.Empty;
                    zone.OfType<Point3d>().ToList().ForEach(x => coords += String.Format("\n({0:N2},{1:N2})", x.X, x.Y));
                    ed.WriteMessage("\nCoordenadas:{1}\nPunto dentro de la zona {0}", zoneName, coords);
                    //ed.WriteMessage("\n{0}", zoneName);
                }
            }
            return null;
        }
        
    }
}
