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
    public partial class Venta : Form
    {
        DataTable dt;
        SqlDataAdapter da;
        SqlConnection scc;
        public Venta()
        {
           
            InitializeComponent();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'abarrotesSanRafaelDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.abarrotesSanRafaelDataSet.Cliente);
            // TODO: This line of code loads data into the 'abarrotesSanRafaelDataSet.Venta' table. You can move, or remove it, as needed.
            this.ventaTableAdapter.Fill(this.abarrotesSanRafaelDataSet.Venta);
            // TODO: This line of code loads data into the 'abarrotesSanRafaelDataSet.Producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter1.Fill(this.abarrotesSanRafaelDataSet.Producto);
            // TODO: This line of code loads data into the 'empresaDataSet1.producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter.Fill(this.empresaDataSet1.producto);
            // TODO: This line of code loads data into the 'empresaDataSet1.detalleTemporal' table. You can move, or remove it, as needed.
            this.detalleTemporalTableAdapter.Fill(this.empresaDataSet1.detalleTemporal);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            agregarProducto(dataGridView2);

        }

        public void agregarProducto(DataGridView dgv)
        {
            try
            {
                scc = new SqlConnection("Data Source=DESKTOP-OIBTPLU;Initial Catalog=AbarrotesSanRafael;Integrated Security=True");
                scc.Open();
                da= new SqlDataAdapter("select * from Producto", scc);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection scc = new SqlConnection("Data Source=DESKTOP-OIBTPLU;Initial Catalog=AbarrotesSanRafael;Integrated Security=True");
                scc.Open();
                SqlDataAdapter sqc = new SqlDataAdapter("select * from Producto where nombreProducto = '" + textBox1.Text + "'", scc);
                DataTable dt = new DataTable();
                sqc.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection scc = new SqlConnection("Data Source=DESKTOP-OIBTPLU;Initial Catalog=AbarrotesSanRafael;Integrated Security=True");
                scc.Open();
                SqlDataAdapter sqc = new SqlDataAdapter("select * from Producto", scc);
                DataTable dt = new DataTable();
                sqc.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AgregarCliente agt = new AgregarCliente();
            agt.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "")
            {
                MessageBox.Show("No se permite el ingreso de cantidades vacias");
            }
            else if (!(int.Parse(txtCantidad.Text) > 0))
            {
                MessageBox.Show("Solo puede ingresar cantidades mayores a 0 y que ademas sean enteros");
            }
            else if (int.Parse(txtCantidad.Text) > 
                int.Parse(dataGridView2.CurrentRow.Cells[7].Value.ToString().Trim()))
            {
                MessageBox.Show("No hay suficientes productos en existencia");
            }
            else
            {
                try
                {
                    SqlConnection scc = new SqlConnection("Data Source=DESKTOP-OIBTPLU;Initial Catalog=AbarrotesSanRafael;Integrated Security=True");
                    scc.Open();
                    SqlCommand sqc = new SqlCommand("hacerVenta", scc);
                    sqc.CommandType = CommandType.StoredProcedure;
                    sqc.Parameters.AddWithValue("@fechaVenta", DateTime.Today);
                    sqc.Parameters.AddWithValue("@cantidadVendida", txtCantidad.Text.Trim());
                    sqc.Parameters.AddWithValue("@idCliente", cmbCliente.Text.Trim());
                    sqc.Parameters.AddWithValue("@idProducto", dataGridView2.CurrentRow.Cells[0].Value.ToString().Trim());
                    sqc.ExecuteNonQuery();

                    //dataGridView2.CurrentRow.Cells[3].Value.ToString().Trim()
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
           
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))

            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SqlConnection scc = new SqlConnection("Data Source=DESKTOP-OIBTPLU;Initial Catalog=AbarrotesSanRafael;Integrated Security=True");
            scc.Open();
            SqlDataAdapter sqc = new SqlDataAdapter("select * from Venta", scc);
            DataTable dt = new DataTable();
            sqc.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SqlConnection scc = new SqlConnection("Data Source=DESKTOP-OIBTPLU;Initial Catalog=AbarrotesSanRafael;Integrated Security=True");
            scc.Open();

            ReporteVenta rpv = new ReporteVenta();
            rpv.Show();

            //SqlCommand sqc = new SqlCommand("cambiarVenta", scc);
            //sqc.CommandType = CommandType.StoredProcedure;
            //sqc.ExecuteNonQuery();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SqlConnection scc = new SqlConnection("Data Source=DESKTOP-OIBTPLU;Initial Catalog=AbarrotesSanRafael;Integrated Security=True");
            scc.Open();
            SqlCommand sqc = new SqlCommand("cambiarVenta", scc);
            sqc.CommandType = CommandType.StoredProcedure;
            sqc.ExecuteNonQuery();
        }
    }
}
