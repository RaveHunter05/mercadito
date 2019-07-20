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
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text=="" || txtContraseña.Text=="" || txtConfirmar.Text == "" || cmbRol.Text == "")
            {
                MessageBox.Show("Asegurese de llenar todos los requisitos de registro");
            }
            else if (txtContraseña.Text != txtConfirmar.Text)
            {
                MessageBox.Show("Las contraseñas deben ser iguales!");
            }
            else if(!(cmbRol.Text == "Admin" || cmbRol.Text== "Usuario"))
            {
                MessageBox.Show("No se puede ingresar otro rol que no sea admin o usuario");
            }
            else
            {
                try
                {
                    SqlConnection scc = new SqlConnection("Data Source=DESKTOP-OIBTPLU;Initial Catalog=AbarrotesSanRafael;Integrated Security=True");
                    scc.Open();
                    SqlCommand sqc = new SqlCommand("ingresarUsuario", scc);
                    sqc.CommandType = CommandType.StoredProcedure;
                    sqc.Parameters.AddWithValue("@usuario", txtNombre.Text);
                    sqc.Parameters.AddWithValue("@contraseña", txtContraseña.Text);
                    sqc.Parameters.AddWithValue("@rol", cmbRol.Text);
                    sqc.ExecuteNonQuery();
                    MessageBox.Show("Registrado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }




            //try
            //{
            //    SqlCommand sqc = new SqlCommand("", scc);
            //    sqc.CommandType = CommandType.StoredProcedure;

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    throw;
            //}
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
