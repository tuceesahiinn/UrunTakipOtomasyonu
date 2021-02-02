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
    public partial class frmBillingProductRegulation : Form
    {
        public frmBillingProductRegulation()
        {
            InitializeComponent();
        }

        public string productId;
        SqlConnect connect = new SqlConnect();

        void Clean()
        {
            txtProductId.Text = "";
            txtProductName.Text = "";
            txtNumber.Text = "";
            txtUnitPrice.Text = "";
            txtAmount.Text = "";
        }

        private void frmBillingProductRegulation_Load(object sender, EventArgs e)
        {
            txtProductId.Text = productId;
            SqlCommand command = new SqlCommand("Select * from BillingDetail where [Ürün Id]=@p1",connect.connection());
            command.Parameters.AddWithValue("@p1", productId);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                txtProductName.Text = dr[1].ToString();
                txtNumber.Text = dr[2].ToString();
                txtUnitPrice.Text = dr[3].ToString();
                txtAmount.Text = dr[4].ToString();
                connect.connection().Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Delete from BillingDetail where [Ürün Id]=@p1", connect.connection());
            command.Parameters.AddWithValue("@p1", txtProductId.Text);
            command.ExecuteNonQuery();
            connect.connection().Close();
            MessageBox.Show("Ürün fatura bilgisi sistemden silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update BillingDetail set [Ürün Adı]=@p1,Adet=@p2,[Birim Fiyat]=@p3,Tutar=@p4 where [Ürün Id]=@p5", connect.connection());
            command.Parameters.AddWithValue("@p1", txtProductName.Text);
            command.Parameters.AddWithValue("@p2", txtNumber.Text);
            command.Parameters.AddWithValue("@p3", decimal.Parse(txtUnitPrice.Text));
            command.Parameters.AddWithValue("@p4", decimal.Parse(txtAmount.Text));
            command.Parameters.AddWithValue("@p5", txtProductId.Text);
            command.ExecuteNonQuery();
            connect.connection().Close();
            MessageBox.Show("Ürün fatura bilgisi güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Clean();
        }
    }
}
