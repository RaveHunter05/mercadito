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
    public partial class Form2 : Form
    {
        public Form2(string Rol)
        {
           
            MessageBox.Show("Su rol es de"+ Rol );
            InitializeComponent();
            CenterToScreen();

            if (Rol == "Usuario")
            {
               btnProducto.Visible = false;
                btnProveedor.Visible = false;
                btnFacturar.Visible = false;
                bdnCompra.Visible = false;
                btnRegistrar.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pnPrincipal.Width == 144)
            {
                pnPrincipal.Width = 56;
                pictureBox1.Image = WindowsFormsApp2.Properties.Resources.icons8_doble_derecha_50;
                label1.Hide();
            }
            else
            {
                pnPrincipal.Width = 144;
                pictureBox1.Image = WindowsFormsApp2.Properties.Resources.icons8_doble_izquierda_50;
                label1.Show();

            }
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
         
        }

        private void panel1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Leave(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panel7_Click(object sender, EventArgs e)
        {
            //string Produto = "factura";
            //string disminutivo = "ftr";
            //tumadre(ref Produto, ref disminutivo);
            panelPrincipal.Controls.Clear();
            factura ftr = new factura();
            ftr.TopLevel = false;
            ftr.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(ftr);
            ftr.AccessibleRole = AccessibleRole.Default;
            ftr.FormBorderStyle = FormBorderStyle.None;



            ftr.Show();


        }

        void tumadre(ref string compon, ref string disminutivo)
        {
            //panelPrincipal.Controls.Clear();
            //compon disminutivo = new compon();
            //disminutivo.TopLevel = false;
            //disminutivo.Dock = DockStyle.Fill;
            //disminutivo.FormBorderStyle = FormBorderStyle.None;
            //this.panelPrincipal.Controls.Add(disminutivo);
            //disminutivo.AccessibleRole = AccessibleRole.Default;
            


            //disminutivo.Show();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            //string Produto = "Productos";
            //string disminutivo = "prd";
            //tumadre(ref Produto, ref disminutivo);

            panelPrincipal.Controls.Clear();
            Productos prd = new Productos();
            prd.TopLevel = false;
            prd.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(prd);
            prd.AccessibleRole = AccessibleRole.Default;
            prd.FormBorderStyle = FormBorderStyle.None;



            prd.Show();
            //}
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Environment.Exit(0);

        }

        private void panel6_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            Registrar rgt = new Registrar();
            rgt.TopLevel = false;
            rgt.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(rgt);
            rgt.AccessibleRole = AccessibleRole.Default;
            rgt.FormBorderStyle = FormBorderStyle.None;



            rgt.Show();
          
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            Productos prd = new Productos();
            prd.TopLevel = false;
            prd.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(prd);
            prd.AccessibleRole = AccessibleRole.Default;
            prd.FormBorderStyle = FormBorderStyle.None;



            prd.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            Registrar rgt = new Registrar();
            rgt.TopLevel = false;
            rgt.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(rgt);
            rgt.AccessibleRole = AccessibleRole.Default;
            rgt.FormBorderStyle = FormBorderStyle.None;



            rgt.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            factura ftr = new factura();
            ftr.TopLevel = false;
            ftr.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(ftr);
            ftr.AccessibleRole = AccessibleRole.Default;
            ftr.FormBorderStyle = FormBorderStyle.None;



            ftr.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Environment.Exit(0);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            Venta vt=new Venta();
            vt.TopLevel = false;
            vt.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(vt);
            vt.AccessibleRole = AccessibleRole.Default;
            vt.FormBorderStyle = FormBorderStyle.None;



            vt.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            Compra cpr = new Compra();
            cpr.TopLevel = false;
            cpr.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(cpr);
            cpr.AccessibleRole = AccessibleRole.Default;
            cpr.FormBorderStyle = FormBorderStyle.None;



            cpr.Show();
        }

        public void button4_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            Proveedor prv = new Proveedor();
            prv.TopLevel = false;
            prv.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(prv);
            prv.AccessibleRole = AccessibleRole.Default;
            prv.FormBorderStyle = FormBorderStyle.None;



            prv.Show();
        }
    } }
