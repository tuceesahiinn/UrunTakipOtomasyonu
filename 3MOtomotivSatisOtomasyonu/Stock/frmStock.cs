using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraCharts;

namespace _3MOtomotivSatisOtomasyonu.Stock
{
    public partial class frmStock : Form
    {
        public frmStock()
        {
            InitializeComponent();
        }

        SqlConnect connect = new SqlConnect();

        private void frmStock_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Ad, sum(Adet) as [Stok Miktarı] from Product group by Ad", connect.connection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
            SqlCommand command = new SqlCommand("Select Ad, sum(Adet) as [Stok Miktarı] from Product group by Ad", connect.connection());
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            connect.connection().Close();            
        }
    }
}
