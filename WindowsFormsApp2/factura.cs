using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class factura : Form
    {
        public factura()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void factura_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'empresaDataSet1.factura' table. You can move, or remove it, as needed.
            this.facturaTableAdapter.Fill(this.empresaDataSet1.factura);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SqlConnection scc = new SqlConnection("Data Source=DESKTOP-OIBTPLU;Initial Catalog=AbarrotesSanRafael;Integrated Security=True");
            scc.Open();

            Convert.ToDateTime(dateTimePicker1.Value.ToString("d/M/yyyy"));
            Convert.ToDateTime(dateTimePicker2.Value.ToString("d/M/yyyy"));

            


            if (cmb1.Text == "Producto")
            {
                SqlCommand sqc = new SqlCommand("productoFecha", scc);
                sqc.CommandType = CommandType.StoredProcedure;
                sqc.Parameters.AddWithValue("@fechaEntrada",
                    Convert.ToDateTime(dateTimePicker1.Value.ToString("d/M/yyyy")));
                sqc.Parameters.AddWithValue("@fechaTope",
                    Convert.ToDateTime(dateTimePicker2.Value.ToString("d/M/yyyy")));

                SqlDataAdapter sda = new SqlDataAdapter(sqc);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (cmb1.Text == "Compra")
            {
                SqlCommand sqc = new SqlCommand("compraFecha", scc);
                sqc.CommandType = CommandType.StoredProcedure;
                sqc.Parameters.AddWithValue("@fechaEntrada",
                    Convert.ToDateTime(dateTimePicker1.Value.ToString("d/M/yyyy")));
                sqc.Parameters.AddWithValue("@fechaTope",
                    Convert.ToDateTime(dateTimePicker2.Value.ToString("d/M/yyyy")));

                SqlDataAdapter sda = new SqlDataAdapter(sqc);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (cmb1.Text == "Venta")
            {
                SqlCommand sqc = new SqlCommand("ventaFecha", scc);
                sqc.CommandType = CommandType.StoredProcedure;
                sqc.Parameters.AddWithValue("@fechaEntrada",
                    Convert.ToDateTime(dateTimePicker1.Value.ToString("d/M/yyyy")));
                sqc.Parameters.AddWithValue("@fechaTope",
                    Convert.ToDateTime(dateTimePicker2.Value.ToString("d/M/yyyy")));

                SqlDataAdapter sda = new SqlDataAdapter(sqc);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Por favor seleccione uno de los valores correspondientes");
            }

            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PasarDatos psd = new PasarDatos();

            string entrar = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string salir = dateTimePicker2.Value.ToString("yyyy-MM-dd");

            ReporteFactura rpf = new ReporteFactura(entrar, salir);
            rpf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
