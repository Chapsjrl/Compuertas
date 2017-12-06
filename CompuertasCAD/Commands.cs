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
using Autodesk.AutoCAD.Windows;
using AutoCADAPI.Lab3.UI;
using AutoCADAPI.Lab3.Controller;

namespace AutoCADAPI.Lab3
{
    public class Commands
    {
        PaletteSet compuertasSet;
        public static CompuertasUI myControlCompuertas;
        
        [CommandMethod("TestInitUI")]
        public void TestUI()
        {
            //inicializa la interfaz
            compuertasSet = new PaletteSet("Compuertas");
            myControlCompuertas = new CompuertasUI();
            compuertasSet.Add("Galería", myControlCompuertas);
            compuertasSet.Dock = DockSides.Left;
            compuertasSet.Visible = true;
        } 

        [CommandMethod("TestDictionary")]
        public void Dictionary()
        {
            ObjectId obj;
            if(Selector.Entity("Selecciona una entidad", out obj))
            {
                TransactionWrapper tr = new TransactionWrapper();
                tr.Run(DictionaryTask, obj);
            }
        }

        private object DictionaryTask(Document doc, Transaction tr, object[] input)
        {
            Editor ed = Application.DocumentManager.MdiActiveDocument.Editor;
            Entity ent = ((ObjectId)input[0]).GetObject(OpenMode.ForRead) as Entity;
            DictionaryManager man = new DictionaryManager();
            //Abrimos el diccionario
            var extD = man.GetExtensionD(tr, doc, ent);
            man.SetData(extD, tr, "Prueba", "Chaps", DateTime.Now.ToShortDateString());
            var data = man.GetData(extD, tr, "Prueba");
            ed.WriteMessage("Nombre: {0}, Fecha de Registro: {1}", data[0], data[1]);
            return null;
        }

        /// <summary>
        /// Las compuertas insertadas en el plano
        /// </summary>
        Dictionary<Handle, Compuerta> Compuertas;
        /// <summary>
        /// Define un comando que prueba la inserción de la compuerta AND
        /// </summary>
        [CommandMethod("InsertAND")]
        public void InsertAND()
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
        /// Define un comando que prueba la inserción de la compuerta OR
        /// </summary>
        [CommandMethod("InsertOR")]
        public void InsertOR()
        {
            if (Compuertas == null)
                Compuertas = new Dictionary<Handle, Compuerta>();
            Point3d pt;
            if (Selector.Point("Selecciona el punto de inserción de la compuerta", out pt))
            {
                TransactionWrapper tr = new TransactionWrapper();
                var cmp = tr.Run(InsertCompuertaTask, new OR(), pt) as Compuerta;
                Compuertas.Add(cmp.Id, cmp);
            }
        }
        /// <summary>
        /// Define un comando que prueba la inserción de la compuerta NAND
        /// </summary>
        [CommandMethod("InsertNAND")]
        public void InsertNAND()
        {
            if (Compuertas == null)
                Compuertas = new Dictionary<Handle, Compuerta>();
            Point3d pt;
            if (Selector.Point("Selecciona el punto de inserción de la compuerta", out pt))
            {
                TransactionWrapper tr = new TransactionWrapper();
                var cmp = tr.Run(InsertCompuertaTask, new NAND(), pt) as Compuerta;
                Compuertas.Add(cmp.Id, cmp);
            }
        }
        /// <summary>
        /// Define un comando que prueba la inserción de la compuerta NOR
        /// </summary>
        [CommandMethod("InsertNOR")]
        public void InsertNOR()
        {
            if (Compuertas == null)
                Compuertas = new Dictionary<Handle, Compuerta>();
            Point3d pt;
            if (Selector.Point("Selecciona el punto de inserción de la compuerta", out pt))
            {
                TransactionWrapper tr = new TransactionWrapper();
                var cmp = tr.Run(InsertCompuertaTask, new NOR(), pt) as Compuerta;
                Compuertas.Add(cmp.Id, cmp);
            }
        }
        /// <summary>
        /// Define un comando que prueba la inserción de la compuerta XOR
        /// </summary>
        [CommandMethod("InsertXOR")]
        public void InsertXOR()
        {
            if (Compuertas == null)
                Compuertas = new Dictionary<Handle, Compuerta>();
            Point3d pt;
            if (Selector.Point("Selecciona el punto de inserción de la compuerta", out pt))
            {
                TransactionWrapper tr = new TransactionWrapper();
                var cmp = tr.Run(InsertCompuertaTask, new XOR(), pt) as Compuerta;
                Compuertas.Add(cmp.Id, cmp);
            }
        }
        /// <summary>
        /// Define un comando que prueba la inserción de la compuerta XOR
        /// </summary>
        [CommandMethod("InsertXNOR")]
        public void InsertXNOR()
        {
            if (Compuertas == null)
                Compuertas = new Dictionary<Handle, Compuerta>();
            Point3d pt;
            if (Selector.Point("Selecciona el punto de inserción de la compuerta", out pt))
            {
                TransactionWrapper tr = new TransactionWrapper();
                var cmp = tr.Run(InsertCompuertaTask, new XNOR(), pt) as Compuerta;
                Compuertas.Add(cmp.Id, cmp);
            }
        }
        /// <summary>
        /// Define un comando que prueba la inserción de la compuerta NOR
        /// </summary>
        [CommandMethod("InsertNOT")]
        public void InsertNOT()
        {
            if (Compuertas == null)
                Compuertas = new Dictionary<Handle, Compuerta>();
            Point3d pt;
            if (Selector.Point("Selecciona el punto de inserción de la compuerta", out pt))
            {
                TransactionWrapper tr = new TransactionWrapper();
                var cmp = tr.Run(InsertCompuertaTask, new NOT(), pt) as Compuerta;
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
        /// Realiza el calculo de una compuerta
        /// </summary>
        //[CommandMethod("TestCompuerta")]
        public void TestCompuerta()
        {
            ObjectId p1Id, p2Id, cmpId;
            Point3d pt1, pt2;
            Editor ed = Application.DocumentManager.MdiActiveDocument.Editor;
            if (Selector.Entity("\nSelecciona un pulso", typeof(Polyline), out p1Id) &&
                Selector.Entity("\nSelecciona la entrada de conexión", out cmpId, out pt1) &&
                Selector.Entity("\nSelecciona un pulso", typeof(Polyline), out p2Id) &&
                Selector.Entity("\nSelecciona la entrada de conexión", out cmpId, out pt2))
            {
                TransactionWrapper tr = new TransactionWrapper();
                Compuerta cmp = this.Compuertas.Values.FirstOrDefault(x => x.Block.Id == cmpId);
                if (cmp != null)
                    tr.Run(TestCompuertaTask, cmp, p1Id, p2Id, pt1, pt2);
                else
                    ed.WriteMessage("No es Compuerta");
            }
        }

        private object TestCompuertaTask(Document doc, Transaction tr, object[] input)
        {
            Compuerta cmp = (Compuerta)input[0];
            cmp.InitBox();
            Polyline p1 = ((ObjectId)input[1]).GetObject(OpenMode.ForRead) as Polyline;
            Polyline p2 = ((ObjectId)input[2]).GetObject(OpenMode.ForRead) as Polyline;
            Point3d pt1 = (Point3d)input[3];
            Point3d pt2 = (Point3d)input[4];
            String zoneA, zoneB;
            //No nos interesa en este ejemplo las coordenadas
            Point3dCollection zone;
            cmp.GetZone(pt1, out zoneA, out zone);
            cmp.GetZone(pt2, out zoneB, out zone);
            InputValue inA = new InputValue() { Name = zoneA, Value = Pulso.GetValues(p1) },
                       inB = new InputValue() { Name = zoneB, Value = Pulso.GetValues(p2) };
            Boolean[] result = cmp.Solve(inA, inB);
            Drawer d = new Drawer(tr);
            Point3d pt;
            if (Selector.Point("Selecciona el punto de inserción de la salida", out pt))
            {
                Pulso p = new Pulso(pt, result);
                p.Draw(d);
                Line lA = new Line(p1.EndPoint, cmp.ConnectionPoints[inA.Name]),
                    lB = new Line(p2.EndPoint, cmp.ConnectionPoints[inB.Name]),
                    lO = new Line(pt, cmp.ConnectionPoints["OUTPUT"]);
                d.Entities(lA, lB, lO);
                cmp.SetData(tr, doc, inA.Value.LastOrDefault(), inB.Value.LastOrDefault());
            }
            return null;
        }





        [CommandMethod("DibujarPulso")]
        public void DPulso()
        {
            Point3d insPt;
            Random r = new Random((int)DateTime.Now.Ticks);
            Boolean[] data = new Boolean[]
            {
                false, true, false, true, false, true, false, true,
                false, true, false, true, false, true, false, true,
                false, true, false, true, false, true, false, true,
                false, true, false, true, false, true, false, true,
                false, true, false, true, false, true, false, true,
                false, true, false, true, false, true, false, true,
                false, true, false, true, false, true, false, true,
                false, true, false, true, false, true, false, true,
                false, true, false, true, false, true, false, true,
                false, true, false, true, false, true, false, true,
                false, true, false, true, false, true, false, true,
                false, true, false, true, false, true, false, true
            };
            int pulsoSize;
            if (Selector.Point("Selecciona el punto de inserción del pulso", out insPt) &&
                Selector.Integer("El tamaño del pulso", out pulsoSize, 4))
            {
                Boolean[] input = new Boolean[pulsoSize];
                for (int i = 0; i < input.Length; i++)
                    input[i] = data[r.Next(data.Length - 1)];
                Pulso p = new Pulso(insPt, input);
                TransactionWrapper tr = new TransactionWrapper();
                tr.Run(DPulsoTask, new Object[] { p });
            }

        }

        private object DPulsoTask(Document doc, Transaction tr, object[] input)
        {
            Drawer d = new Drawer(tr);
            return (input[0] as Pulso).Draw(d);
        }
    }
}
