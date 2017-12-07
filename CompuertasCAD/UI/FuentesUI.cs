using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcadAPP = Autodesk.AutoCAD.ApplicationServices.Application;

namespace AutoCADAPI.Lab3.UI
{
    public partial class FuentesUI : UserControl
    {
        public String PulsoName;

        public FuentesUI()
        {
            InitializeComponent();
        }

        private void Pulso_Click(object sender, EventArgs e)
        {
            PulsoName = (sender as Button).Name;
            var doc = AcadAPP.DocumentManager.MdiActiveDocument;
            //switch{ }
            doc.SendStringToExecute("Pulso"+PulsoName+" ", true, false, false);
        }
    }
}
