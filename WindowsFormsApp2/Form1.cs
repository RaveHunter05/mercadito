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
using System.Timers;
using System.Threading;

namespace WindowsFormsApp2
{
    public partial class frm1 : Form
    {
        int contador = 1;
        int contadorClose = 1;

        static System.Threading.Timer TTimer;

        private static System.Timers.Timer t;

        public frm1()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            rol();

            string user = txtUser.Text;
            string pass = txtPass.Text;
            conexion cs = new conexion();
            SqlCommand sqc = new SqlCommand("verificarUsuario", cs.cd);
            sqc.CommandType = CommandType.StoredProcedure;
            sqc.Parameters.AddWithValue("@user", txtUser.Text);
            sqc.Parameters.AddWithValue("@pass", txtPass.Text);
            sqc.ExecuteNonQuery();

            SqlDataReader dr;
            dr = sqc.ExecuteReader();



            //dr = scc.ExecuteReader();
            //string tipo = dr.ToString();
            //MessageBox.Show(tipo);


            if (dr.Read())
            {
                Form2 mn = new Form2(label4.Text);
                mn.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error " + contador + "\n A los 3 intentos se cerrara");
                contador = contador + 1;

            }
            if (contador > 3)
            {

                deshabilitar();
                contadorClose++;
                if (contadorClose > 3)
                {
                    Close();
                }
            }






            //    if ()
            //    {
            //        Form2 mn = new Form2();
            //        mn.Show();
            //        this.Hide();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Error " + contador + "\n A los 3 intentos se cerrara");
            //        contador = contador + 1;

            //    }
            //    if (contador > 3)
            //    {

            //        deshabilitar();
            //        contadorClose++;
            //        if (contadorClose > 3)
            //        {
            //            Close();
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error" + ex.Message);
            //    throw;
            //}

        }


        public void rol()
        {
            conexion cs = new conexion();

            SqlCommand scc = new SqlCommand("seleccionarRol", cs.cd);
            scc.CommandType = CommandType.StoredProcedure;
            scc.Parameters.AddWithValue("@user", txtUser.Text);
            scc.Parameters.AddWithValue("@pass", txtPass.Text);
            scc.ExecuteNonQuery();

            SqlDataReader di;
            di = scc.ExecuteReader();
            int i = 0;
            string[] Rol;


            while (di.Read())
            {
                MessageBox.Show(di["rol"].ToString());
                label4.Text = di["rol"].ToString();
            }

            string Rol1 = label4.Text;
            PasarDatos psd = new PasarDatos();
            psd.Rol = Rol1;


            di.Close();

            Thread.Sleep(3000);
        }

        public void deshabilitar()
        {
            this.Enabled = false;
            Thread.Sleep(3000);
            contador = 1;
            this.Enabled = true;
        }

        //public void SetTimer() {

        //    t = new System.Timers.Timer(10000);
        //    t.Elapsed += ;
        //    t.AutoReset = true;
        //    t.Enabled = true;
        //}

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Enter(object sender, KeyPressEventArgs e)
        {

        }

        private void Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn1.PerformClick();
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void hola(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn1.PerformClick();
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn1.PerformClick();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private String encryption;
        private String decryption;

        private void button2_Click(object sender, EventArgs e)
        {

        }







        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
