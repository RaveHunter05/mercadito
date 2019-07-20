using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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
    public partial class ReporteCompra : Form
    {
        ReportDocument cryRpt;
        public ReporteCompra()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            //CrystalReport4 crp = new CrystalReport4();
            //crp.Refresh();
            //crystalReportViewer1.ReportSource = crp;

            CrystalReport4 crp = new CrystalReport4();
            crp.Refresh();
            crystalReportViewer1.ReportSource = crp;
            cryRpt = new ReportDocument();
            cryRpt.Load("C:/Users/user/source/repos/WindowsFormsApp2 (1)/WindowsFormsApp2/WindowsFormsApp2/CrystalReport4.rpt");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                ExportOptions exportOptions;
                DiskFileDestinationOptions diskFileDestinationOptions = new DiskFileDestinationOptions();

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Pdf Files|*.pdf";
                sfd.InitialDirectory = "C:/Users/user/Documents/reportes/Ventas";


                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    diskFileDestinationOptions.DiskFileName = sfd.FileName;

                }
                exportOptions = cryRpt.ExportOptions;
                {
                    exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                    exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
                    exportOptions.ExportDestinationOptions = diskFileDestinationOptions;
                    exportOptions.ExportFormatOptions = new PdfRtfWordFormatOptions();

                }
                cryRpt.Export();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
