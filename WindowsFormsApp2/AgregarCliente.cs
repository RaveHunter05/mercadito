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
    public partial class AgregarCliente : Form
    {
        public AgregarCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtID.Text=="" || txtNombre.Text=="" ||txtTelefono.Text=="" 
                || txtDireccion.Text == "")
            {
                MessageBox.Show("No se permite el ingreso de cantidades vacias");
            }
            else
            {
                try
                {
                    SqlConnection scc = new SqlConnection("Data Source=DESKTOP-OIBTPLU;Initial Catalog=AbarrotesSanRafael;Integrated Security=True");
                    scc.Open();
                    SqlCommand sqc = new SqlCommand("agregarCliente", scc);
                    sqc.CommandType = CommandType.StoredProcedure;
                    sqc.Parameters.AddWithValue("@idCliente", txtID.Text);
                    sqc.Parameters.AddWithValue("@nombreCliente", txtNombre.Text);
                    sqc.Parameters.AddWithValue("@direccionCliente", txtDireccion.Text);
                    sqc.Parameters.AddWithValue("@telefonoCliente", txtTelefono.Text);
                    sqc.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
            

        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'abarrotesSanRafaelDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.abarrotesSanRafaelDataSet.Cliente);

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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection scc = new SqlConnection("Data Source=DESKTOP-OIBTPLU;Initial Catalog=AbarrotesSanRafael;Integrated Security=True");
                scc.Open();
                SqlDataAdapter sqc = new SqlDataAdapter("select * from Cliente", scc);
                DataTable dt = new DataTable();
                sqc.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
