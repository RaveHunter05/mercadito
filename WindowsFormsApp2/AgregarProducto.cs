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
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtID.Text=="" || txtNombe.Text=="" 
               ||  txtDescripcion.Text=="" || txtCantidad.Text == "" || txtPrecio.Text==""
               || txtClasificacion.Text=="" || cmbCategoria.Text=="" || cmbEmpresa.Text=="" )
            {
                MessageBox.Show("No pueden ingresar cantidades vacias");
            }
            else if(!(int.Parse(txtCantidad.Text) > 0))
            {
                MessageBox.Show("Solo se permite el ingreso de cantidades mayores a 0 " +
                    "y que sean enteras");
            }
            else if (!(int.Parse(txtPrecio.Text) > 0))
            {
                MessageBox.Show("Solo se permite el ingreso de cantidades mayores a 0 " +
                    "y que sean enteras");
            }
            else
            {
                try
                {
                    SqlConnection scc = new SqlConnection("Data Source=DESKTOP-OIBTPLU;Initial Catalog=AbarrotesSanRafael;Integrated Security=True");
                    scc.Open();
                    SqlCommand sqc = new SqlCommand("RegistrarProducto", scc);
                    sqc.CommandType = CommandType.StoredProcedure;
                    sqc.Parameters.AddWithValue("@idProd", txtID.Text);
                    sqc.Parameters.AddWithValue("@descripcionProd", txtDescripcion.Text);
                    sqc.Parameters.AddWithValue("@nombreProd", txtNombe.Text);
                    sqc.Parameters.AddWithValue("@idproveed", cmbEmpresa.Text);
                    sqc.Parameters.AddWithValue("@fechaAgregar", DateTime.Today);
                    sqc.Parameters.AddWithValue("@fechaVenci", Convert.ToDateTime(dateTimePicker1.Value.ToString("d/M/yyyy")));
                    string status;
                    if ((dateTimePicker1.Value) < (DateTime.Today))
                    {
                        status = "Expirado";
                        txtClasificacion.Text = status;
                    }
                    else
                    {
                        status = "En vigencia";
                        txtClasificacion.Text = status;
                    }

                    MessageBox.Show(status);
                    sqc.Parameters.AddWithValue("@status", status);
                    sqc.Parameters.AddWithValue("@existProd", txtCantidad.Text);
                    sqc.Parameters.AddWithValue("@precioProd", txtPrecio.Text);
                    sqc.Parameters.AddWithValue("@idCategory", cmbCategoria.Text);
                    sqc.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }

           
           
        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'abarrotesSanRafaelDataSet.Categoria' table. You can move, or remove it, as needed.
            this.categoriaTableAdapter.Fill(this.abarrotesSanRafaelDataSet.Categoria);
            // TODO: This line of code loads data into the 'abarrotesSanRafaelDataSet.Producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter.Fill(this.abarrotesSanRafaelDataSet.Producto);
            // TODO: This line of code loads data into the 'abarrotesSanRafaelDataSet.Proveedor' table. You can move, or remove it, as needed.
            this.proveedorTableAdapter.Fill(this.abarrotesSanRafaelDataSet.Proveedor);

        }

        private void cmbClasificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbEmpresa.Enabled = false;
            //cmbNatural.Enabled = false;
            //cmbNatural.Text = "";
            //cmbEmpresa.Text = "";
            //if (cmbClasificacion.Text == "Natural")
            //{
            //    cmbEmpresa.Enabled = false;
            //    cmbNatural.Enabled = true;
            //    cmbEmpresa.Text = "";
            //}
            //else if(cmbClasificacion.Text=="Empresa")
            //{
            //    cmbEmpresa.Enabled = true;
            //    cmbNatural.Enabled = false;
            //    cmbNatural.Text = "";
            //}
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string status;
            if((dateTimePicker1.Value) < (DateTime.Today))
                {
                status = "Expirado";
                txtClasificacion.Text = status;
            }
                else
                {
                status = "En vigencia";
                txtClasificacion.Text = status;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    OpenFileDialog f = new OpenFileDialog();
            //    f.InitialDirectory = "C:/Users/user/ImagenesOpenFile";
            //    f.Filter = "All Filles|* . * |JPEGs|*.jpg|Bitmaps|*.bmp|GIFs|*.gif";
            //    f.FilterIndex = 2;
            //    if (f.ShowDialog() == DialogResult.OK)
            //    {
            //        pictureBox1.Image = Image.FromFile(f.FileName);
            //        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    throw;
            //}
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
