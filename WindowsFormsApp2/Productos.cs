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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'abarrotesSanRafaelDataSet.Producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter1.Fill(this.abarrotesSanRafaelDataSet.Producto);
            // TODO: This line of code loads data into the 'empresaDataSet1.producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter.Fill(this.empresaDataSet1.producto);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agregar agr = new Agregar();
            agr.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Editar edt = new Editar();
            edt.Show();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = " ";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection scc = new SqlConnection("Data Source=DESKTOP-OIBTPLU;Initial Catalog=AbarrotesSanRafael;Integrated Security=True");
                scc.Open();
                SqlDataAdapter sqc = new SqlDataAdapter("select * from Producto where nombreProducto = '"+textBox1.Text+"'", scc);
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            AgregarProducto agp = new AgregarProducto();
            agp.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SqlConnection scc = new SqlConnection("Data Source=DESKTOP-OIBTPLU;Initial Catalog=AbarrotesSanRafael;Integrated Security=True");
            scc.Open();
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
            try
            {
                SqlCommand sqc = new SqlCommand("DarbajaProducto", scc);
                sqc.CommandType = CommandType.StoredProcedure;
                sqc.Parameters.AddWithValue("@idprod", id);
                sqc.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PasarDatosProducto pd = new PasarDatosProducto();
            pd.ID = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
            pd.fecha = dataGridView1.CurrentRow.Cells[5].Value.ToString().Trim();
            pd.precio = dataGridView1.CurrentRow.Cells[8].Value.ToString().Trim();

            EditarProducto edt = new EditarProducto(pd.ID, pd.fecha, pd.precio);
            edt.Show();

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
