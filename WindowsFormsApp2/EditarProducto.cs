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
    public partial class EditarProducto : Form
    {
        public EditarProducto(string id, string fecha, string precio)
        {
            InitializeComponent();
            txtID.Text = id;
            txtPrecio.Text = precio;
            txtVencimiento.Text = fecha;

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            SqlConnection scc = new SqlConnection("Data Source=DESKTOP-OIBTPLU;Initial Catalog=AbarrotesSanRafael;Integrated Security=True");
            scc.Open();

            try
            {
                SqlCommand sqc = new SqlCommand("EditarProducto",scc);
                sqc.CommandType = CommandType.StoredProcedure;
                sqc.Parameters.AddWithValue("@idproduc", txtID.Text);
                sqc.Parameters.AddWithValue("@fechaVenc", txtVencimiento.Text);
                sqc.Parameters.AddWithValue("@precio ", txtPrecio.Text);
                sqc.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
