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
    public partial class EditarProveedor : Form
    {
        public EditarProveedor(string ID, string RUC, string Nombre, string telefono, string correo, string direccion, string fecha, string tipo)
        {
            InitializeComponent();
            txtID.Text = ID;
            
            if (RUC!="")
            {
                txtRUC.Text = RUC;
                txtRUC.Enabled = true;
            }
           
            txtNombre.Text = Nombre;
            txtTelefono.Text = telefono;
            txtCorreo.Text = correo;
            txtDireccion.Text = direccion;
            //MessageBox.Show(tipo);
            txtTipo.Text = tipo;
        } 

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            SqlConnection scc = new SqlConnection("Data Source=DESKTOP-OIBTPLU;Initial Catalog=AbarrotesSanRafael;Integrated Security=True");
            scc.Open();

            try
            {
                if (txtTipo.Text=="Natural")
                {
                    SqlCommand sqc=new SqlCommand("EditarProveedorNatural", scc);
                    sqc.CommandType = CommandType.StoredProcedure;
                    sqc.Parameters.AddWithValue("@id",txtID.Text);
                    sqc.Parameters.AddWithValue("@nombreNatural", txtNombre.Text);
                    sqc.Parameters.AddWithValue("@RUC", txtRUC.Text);
                    sqc.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                    sqc.Parameters.AddWithValue("@mail", txtCorreo.Text);
                    sqc.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                    sqc.ExecuteNonQuery();

                    //@id,@nombreNatural, @RUC, @telefono, @mail,@direccion
                }
                else
                {
                    SqlCommand sqc = new SqlCommand("EditarProveedorEmpresa", scc);
                    sqc.CommandType = CommandType.StoredProcedure;
                    sqc.Parameters.AddWithValue("@id", txtID.Text);
                    sqc.Parameters.AddWithValue("@nombreEmpresa", txtNombre.Text);
                    sqc.Parameters.AddWithValue("@RUC", txtRUC.Text);
                    sqc.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                    sqc.Parameters.AddWithValue("@mail", txtCorreo.Text);
                    sqc.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                    sqc.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            

        }



        private void EditarProveedor_Load(object sender, EventArgs e)
        {

            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtRUC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
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
    }
}
