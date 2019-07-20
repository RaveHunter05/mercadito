using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Compra : Form
    {
        public Compra()
        {
            InitializeComponent();
        }

        private void Compra_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'abarrotesSanRafaelDataSet.Proveedor' table. You can move, or remove it, as needed.
            this.proveedorTableAdapter.Fill(this.abarrotesSanRafaelDataSet.Proveedor);
            // TODO: This line of code loads data into the 'abarrotesSanRafaelDataSet.Compra' table. You can move, or remove it, as needed.
            this.compraTableAdapter.Fill(this.abarrotesSanRafaelDataSet.Compra);
            // TODO: This line of code loads data into the 'abarrotesSanRafaelDataSet.Producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter.Fill(this.abarrotesSanRafaelDataSet.Producto);
            // TODO: This line of code loads data into the 'empresaDataSet1.entradas' table. You can move, or remove it, as needed.
            this.entradasTableAdapter.Fill(this.empresaDataSet1.entradas);
            // TODO: This line of code loads data into the 'empresaDataSet1.factura' table. You can move, or remove it, as needed.
            this.facturaTableAdapter.Fill(this.empresaDataSet1.factura);
            // TODO: This line of code loads data into the 'empresaDataSet1.detalleTemporal' table. You can move, or remove it, as needed.
            this.detalleTemporalTableAdapter.Fill(this.empresaDataSet1.detalleTemporal);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarProveedor agp = new AgregarProveedor();
            agp.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection scc = new SqlConnection("Data Source=DESKTOP-OIBTPLU;Initial Catalog=AbarrotesSanRafael;Integrated Security=True");
                scc.Open();
                SqlDataAdapter sqc = new SqlDataAdapter("select * from Producto where nombreProducto = '" + textBox6.Text + "'", scc);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
           if(txtCantidad.Text=="" || txtPrecio.Text == "")
            {
                MessageBox.Show("No se permite el ingreso de cantidades vacias");
            }
           else if (!(int.Parse(txtCantidad.Text.Trim()) > 0))
            {
                MessageBox.Show("Solo puede ingresar cantidades mayores a 0 y que ademas sean enteros");
            }
            else
            {
                try
                {
                    SqlConnection scc = new SqlConnection("Data Source=DESKTOP-OIBTPLU;Initial Catalog=AbarrotesSanRafael;Integrated Security=True");
                    scc.Open();
                    SqlCommand sqc = new SqlCommand("hacerCompra", scc);
                    sqc.CommandType = CommandType.StoredProcedure;

                    sqc.Parameters.AddWithValue("@idProveedor", dataGridView2.CurrentRow.Cells[3].Value.ToString().Trim());
                    sqc.Parameters.AddWithValue("@idProducto", dataGridView2.CurrentRow.Cells[0].Value.ToString().Trim());
                    sqc.Parameters.AddWithValue("@fechaCompra", DateTime.Today);
                    sqc.Parameters.AddWithValue("@cantidadCompra", txtCantidad.Text.Trim());
                    sqc.Parameters.AddWithValue("@precioCompra", txtPrecio.Text.Trim());
                    sqc.ExecuteNonQuery();


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

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SqlConnection scc = new SqlConnection("Data Source=DESKTOP-OIBTPLU;Initial Catalog=AbarrotesSanRafael;Integrated Security=True");
            scc.Open();

            ReporteCompra rpc = new ReporteCompra();
            rpc.Show();

            

           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SqlConnection scc = new SqlConnection("Data Source=DESKTOP-OIBTPLU;Initial Catalog=AbarrotesSanRafael;Integrated Security=True");
            scc.Open();
            SqlDataAdapter sqc = new SqlDataAdapter("select * from Compra", scc);
            DataTable dt = new DataTable();
            sqc.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SqlConnection scc = new SqlConnection("Data Source=DESKTOP-OIBTPLU;Initial Catalog=AbarrotesSanRafael;Integrated Security=True");
            scc.Open();
            SqlCommand sqc = new SqlCommand("cambiarCompra", scc);
            sqc.CommandType = CommandType.StoredProcedure;
            sqc.ExecuteNonQuery();
        }
    }
}
