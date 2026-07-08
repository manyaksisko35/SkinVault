using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class SqlBaglantim
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-LLGPVCJ\SQLEXPRESS;Initial Catalog=SkinVaultDB;Integrated Security=True;TrustServerCertificate=True");
            baglan.Open();
            return baglan;
        }
    }
    
}
