using AutoCADAPI.Lab2;
using AutoCADAPI.Lab3.Controller;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCADAPI.Lab3
{
    public class Cable
    {
        public Line Geometry;

        public Cable(Point3d start, Point3d end)
        {
            this.Geometry = new Line(start, end);
        }

        public void SetData (Transaction tr, Document doc, Boolean[] data)
        {
            DictionaryManager dman = new DictionaryManager();
            //Abrimos el diccionario de extension de la entidad
            ObjectId idDic = dman.GetExtensionD(tr, doc, this.Geometry);

            dman.SetData(idDic, tr, "data", data.Select(x => x ? "1" : "0").ToArray());
        }

        public Boolean[] GetData(Transaction tr, Document doc)
        {
            DictionaryManager dman = new DictionaryManager();
            ObjectId idDic = dman.GetExtensionD(tr, doc, this.Geometry);
            return dman.GetData(idDic, tr, "data").Select(x => x == "1").ToArray();
        }

        public static Cable InsertCable(Point3d start, Point3d end, Drawer dr)
        {
            Cable cable = new Cable(start, end);
            dr.Entity(cable.Geometry);
            return cable;
        }
    }
}
