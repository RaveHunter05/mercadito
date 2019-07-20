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
    public partial class ReporteVenta : Form
    {
        ReportDocument cryRpt;
        public ReporteVenta()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            


        }

        private void crystalReportViewer1_Load_1(object sender, EventArgs e)
        {
            CrystalReport5 crp = new CrystalReport5();
            crp.Refresh();
            crystalReportViewer1.ReportSource = crp;
            cryRpt = new ReportDocument();
            cryRpt.Load("C:/Users/user/source/repos/WindowsFormsApp2 (1)/WindowsFormsApp2/WindowsFormsApp2/CrystalReport5.rpt");
            //crystalReportViewer1.ReportSource = cryRpt;
            //crystalReportViewer1.Refresh();



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
                
                //PdfRtfWordFormatOptions CrFormatTypeOptions = new PdfRtfWordFormatOptions();
                //CrDiskFileDestinationOptions.DiskFileName = "c:\\csharp.net-informations.pdf";
                //CrExportOptions = cryRpt.ExportOptions;
                //{
                //    CrExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                //    CrExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
                //    CrExportOptions.DestinationOptions = CrDiskFileDestinationOptions;
                //    CrExportOptions.FormatOptions = CrFormatTypeOptions;
                //}
                //cryRpt.Export();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
