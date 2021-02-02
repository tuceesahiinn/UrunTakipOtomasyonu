using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _3MOtomotivSatisOtomasyonu
{
    public class SqlConnect
    {
        public SqlConnection connection()
        {
            SqlConnection connect = new SqlConnection(@"Data Source=TUGCE;Initial Catalog=UrunSatisTakipOtomasyonu;Integrated Security=True");
            connect.Open();
            return connect;
        }
    }
}
