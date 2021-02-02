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

namespace _3MOtomotivSatisOtomasyonu
{
    public partial class frmDirectory : Form
    {
        public frmDirectory()
        {
            InitializeComponent();
        }

        SqlConnect connect = new SqlConnect();

        void GetCustomerDirectory()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Ad,Soyad,Telefon1,Telefon2,Mail from Customer", connect.connection());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void GetCompanyDirectory()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select FirmaAdi,YetkiliAdSoyad,YetkiliStatu,Telefon1,Telefon2,Telefon3,Fax,Mail from Company", connect.connection());
            da.Fill(dt);
            gridControl2.DataSource = dt;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmMail frmMail = new frmMail();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                frmMail.mail = dr["Mail"].ToString();
            }
            frmMail.Show();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            frmMail frmMail = new frmMail();
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            if (dr != null)
            {
                frmMail.mail = dr["Mail"].ToString();
            }
            frmMail.Show();
        }

        private void frmDirectory_Load(object sender, EventArgs e)
        {
            GetCustomerDirectory();
            GetCompanyDirectory();
        }
    }
}
