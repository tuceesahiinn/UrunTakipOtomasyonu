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

namespace _3MOtomotivSatisOtomasyonu.Billing
{
    public partial class frmBillingProductDetail : Form
    {
        public frmBillingProductDetail()
        {
            InitializeComponent();
        }

        public string id;
        SqlConnect connect = new SqlConnect();

        void List()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from BillingDetail where FaturaId='"+id+"'", connect.connection());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmBillingProductRegulation fr = new frmBillingProductRegulation();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                fr.productId = dr["Ürün Id"].ToString();
            }
            fr.Show();
        }

        private void frmBillingProductDetail_Load(object sender, EventArgs e)
        {
            List();
        }
    }
}
