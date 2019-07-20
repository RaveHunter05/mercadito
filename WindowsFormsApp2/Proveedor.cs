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
    public partial class Proveedor : Form
    {
        public Proveedor()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'abarrotesSanRafaelDataSet.Proveedor' table. You can move, or remove it, as needed.
            this.proveedorTableAdapter1.Fill(this.abarrotesSanRafaelDataSet.Proveedor);
            // TODO: This line of code loads data into the 'empresaDataSet1.proveedor' table. You can move, or remove it, as needed.
            this.proveedorTableAdapter.Fill(this.empresaDataSet1.proveedor);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarProveedor agp = new AgregarProveedor();

            agp.Show();

        }

        void refrescar()
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            

            try
            {
                SqlConnection scc = new SqlConnection("Data Source=DESKTOP-OIBTPLU;Initial Catalog=AbarrotesSanRafael;Integrated Security=True");
                scc.Open();
                SqlDataAdapter sqc = new SqlDataAdapter("select * from Proveedor",scc);
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

       

        private void button2_Click(object sender, EventArgs e)
        {
            PasarDatos psd = new PasarDatos();
            psd.ID = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
            psd.RUC = dataGridView1.CurrentRow.Cells[1].Value.ToString().Trim();
            if (dataGridView1.CurrentRow.Cells[2].Value.ToString() == "")
            {
                psd.Nombre = dataGridView1.CurrentRow.Cells[3].Value.ToString().Trim();
                psd.TipoProveedor = "Natural";
            }
            else
            {
                psd.Nombre = dataGridView1.CurrentRow.Cells[2].Value.ToString().Trim();
                psd.TipoProveedor = "Empresa";
            }
            psd.Telefono = dataGridView1.CurrentRow.Cells[4].Value.ToString().Trim();
            psd.Correo = dataGridView1.CurrentRow.Cells[5].Value.ToString().Trim();
            psd.Direccion = dataGridView1.CurrentRow.Cells[6].Value.ToString().Trim();
            psd.Fecha = dataGridView1.CurrentRow.Cells[7].Value.ToString().Trim();


            EditarProveedor edt = new EditarProveedor(psd.ID,psd.RUC,psd.Nombre,psd.Telefono,psd.Correo,psd.Direccion,psd.Fecha,psd.TipoProveedor);
            edt.Show();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void borrar()
        {
            SqlConnection sqc = new SqlConnection();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
            SqlConnection scc = new SqlConnection("Data Source=DESKTOP-OIBTPLU;Initial Catalog=AbarrotesSanRafael;Integrated Security=True");
            scc.Open();

            try
            {
                SqlCommand sqc = new SqlCommand("DarbajaProveedor",scc);
                sqc.CommandType = CommandType.StoredProcedure;
                sqc.Parameters.AddWithValue("@idprovee",id);
                sqc.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection scc = new SqlConnection("Data Source=DESKTOP-OIBTPLU;Initial Catalog=AbarrotesSanRafael;Integrated Security=True");
                scc.Open();
                SqlDataAdapter sqc = new SqlDataAdapter(
                    "select * from Proveedor where idProveedor = '"+textBox1.Text+"'", scc);
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
