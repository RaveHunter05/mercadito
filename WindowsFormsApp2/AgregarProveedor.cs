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
    public partial class AgregarProveedor : Form
    {
        public AgregarProveedor()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClasificacion.Text == "Empresa")
            {
                txtRUC.Enabled = true;
            }
            else
            {
                txtRUC.Enabled = false;
            }
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtID.Text=="" || 
                txtTelefono.Text == "" || txtCorreo.Text == "" ||
                txtNombre.Text == "" || cmbClasificacion.Text == "" ||
                txtDireccion.Text == "" )
            {
                MessageBox.Show("No se permite el ingreso de cantidades vacias");
            }
            else
            {
                try
                {
                    SqlConnection scc = new SqlConnection("Data Source=DESKTOP-OIBTPLU;Initial Catalog=AbarrotesSanRafael;Integrated Security=True");
                    scc.Open();
                    if (cmbClasificacion.Text == "Natural")
                    {
                        SqlCommand sqc = new SqlCommand("RegistrarProveedorNatural", scc);
                        sqc.CommandType = CommandType.StoredProcedure;
                        sqc.Parameters.AddWithValue("@IDproveedor", txtID.Text);
                        sqc.Parameters.AddWithValue("@RUC", txtRUC.Text);
                        sqc.Parameters.AddWithValue("@NombreProveedor", txtNombre.Text);
                        sqc.Parameters.AddWithValue("@TelefonoP", txtTelefono.Text);
                        sqc.Parameters.AddWithValue("@correoP", txtCorreo.Text);
                        sqc.Parameters.AddWithValue("@DireccionP", txtDireccion.Text);
                        sqc.Parameters.AddWithValue("@FechaAgregado", DateTime.Today);
                        sqc.ExecuteNonQuery();

                    }
                    else if (cmbClasificacion.Text == "Empresa")
                    //@IDproveedor,@Ruc,@NombreEmpresa,'',@TelefonoP,@correoP ,@DireccionP,@FechaAgregado
                    {
                        SqlCommand sqc = new SqlCommand("RegistrarProveedorEmpresa", scc);
                        sqc.CommandType = CommandType.StoredProcedure;
                        sqc.Parameters.AddWithValue("@IDproveedor", txtID.Text);
                        sqc.Parameters.AddWithValue("@RUC", txtRUC.Text);
                        sqc.Parameters.AddWithValue("@NombreEmpresa", txtNombre.Text);
                        sqc.Parameters.AddWithValue("@TelefonoP", txtTelefono.Text);
                        sqc.Parameters.AddWithValue("@correoP", txtCorreo.Text);
                        sqc.Parameters.AddWithValue("@DireccionP", txtDireccion.Text);
                        sqc.Parameters.AddWithValue("@FechaAgregado", DateTime.Today);
                        sqc.ExecuteNonQuery();
                        //@IDproveedor,@Ruc,@NombreEmpresa,'',@TelefonoP,@correoP ,@DireccionP,@FechaAgregado
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un dato por favor");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
            
        }

        private void AgregarProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            


            
        }

      

        private void AgregarProveedor_KeyDown(object sender, KeyEventArgs e)
        {
           
                if (e.KeyCode == Keys.Enter)
                {
                    button1.PerformClick();
                }
            

        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtRUC_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtRUC_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void AgregarProveedor_Load(object sender, EventArgs e)
        {
            if (cmbClasificacion.Text == "Empresa")
            {
                txtRUC.Enabled = true;
            }
            else
            {
                txtRUC.Enabled = false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtRUC_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
