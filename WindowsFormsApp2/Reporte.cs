using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Reporte : Form
    {
        public Reporte()
        {
            
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CrystalReport3 crp = new CrystalReport3();
            crp.Refresh();
            crystalReportViewer1.ReportSource = crp;
        }
    }
}
