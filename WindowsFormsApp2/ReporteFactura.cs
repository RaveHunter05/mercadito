using CrystalDecisions.CrystalReports.Engine;
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
    public partial class ReporteFactura : Form
    {
        string Entrada;
        string Salida;
        ReportDocument cryRpt;
        public ReporteFactura(string entrar, string salir )
        {
            InitializeComponent();

            Entrada = entrar;
            Salida = salir;
           

        }


        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DateTime entrada = Convert.ToDateTime(Entrada);
            DateTime salida = Convert.ToDateTime(Salida);

            //MessageBox.Show(entrada.ToString(("yyyy-MM-dd")));

            Producto prd = new Producto();

            //prd.SetDataSource("");
            prd.SetParameterValue("@fechaEntrada", entrada);
            prd.SetParameterValue("@fechaTope", salida);

            //prd.Parameter_fechaEntrada.Equals(entrada);
            //prd.Parameter_fechaEntrada.Equals(salida);
            prd.Refresh();
            crystalReportViewer1.ReportSource = prd;

            cryRpt = new ReportDocument();
            cryRpt.Load("C:/Users/user/source/repos/WindowsFormsApp2 (1)/WindowsFormsApp2/WindowsFormsApp2/Producto.rpt");
            crystalReportViewer1.Refresh();
            


        }
    }
}
