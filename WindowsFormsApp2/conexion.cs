using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class conexion
    {
        public SqlConnection cd = new SqlConnection();
        public conexion()
        {
            try
            {
                cd = new SqlConnection("Data Source=DESKTOP-OIBTPLU;Initial Catalog=AbarrotesSanRafael;User ID=" + "bases1" + ";Password=" + "123456");
                cd.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
