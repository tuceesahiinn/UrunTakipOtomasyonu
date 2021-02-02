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

namespace _3MOtomotivSatisOtomasyonu.Billing
{
    public partial class frmBilling : Form
    {
        public frmBilling()
        {
            InitializeComponent();
        }

        SqlConnect connect = new SqlConnect();

        void List()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from BillingData", connect.connection());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void Clean()
        {
            txtId.Text = "";
            txtSerialNo.Text = "";
            txtItemNo.Text = "";
            mskTxtDate.Text = "";
            mskTxtHour.Text = "";
            txtTaxOffice.Text = "";
            txtReceiver.Text = "";
            txtDeliverer.Text = "";
            txtRecipient.Text = "";
            txtProductId.Text = "";
            txtProductName.Text = "";
            txtNumber.Text = "";
            txtUnitPrice.Text = "";
            txtAmount.Text = "";
            txtBillingId.Text = "";
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtId.Text = dr["Id"].ToString();
                txtSerialNo.Text = dr["SeriNo"].ToString();
                txtItemNo.Text = dr["SiraNo"].ToString();
                txtTaxOffice.Text = dr["VergiDairesi"].ToString();
                mskTxtDate.Text = dr["Tarih"].ToString();
                mskTxtHour.Text = dr["Saat"].ToString();
                txtReceiver.Text = dr["Alici"].ToString();
                txtDeliverer.Text = dr["TeslimEden"].ToString();
                txtRecipient.Text = dr["TeslimAlan"].ToString();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmBillingProductDetail fr = new frmBillingProductDetail();
            DataRow dr =gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                fr.id = dr["Id"].ToString();
            }
            fr.Show();
        }

        private void frmBilling_Load(object sender, EventArgs e)
        {
            List();
            Clean();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBillingId.Text == "")
            {
                SqlCommand command = new SqlCommand("Insert into BillingData(SeriNo,SiraNo,VergiDairesi,Tarih,Saat,Alici,TeslimEden,TeslimAlan) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", connect.connection());
                command.Parameters.AddWithValue("@p1", txtSerialNo.Text);
                command.Parameters.AddWithValue("@p2", txtItemNo.Text);
                command.Parameters.AddWithValue("@p3", txtTaxOffice.Text);
                command.Parameters.AddWithValue("@p4", mskTxtDate.Text);
                command.Parameters.AddWithValue("@p5", mskTxtHour.Text);
                command.Parameters.AddWithValue("@p6", txtReceiver.Text);
                command.Parameters.AddWithValue("@p7", txtDeliverer.Text);
                command.Parameters.AddWithValue("@p8", txtRecipient.Text);
                command.ExecuteNonQuery();
                connect.connection().Close();
                List();
                MessageBox.Show("Fatura bilgisi sisteme eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clean();
            }
            if (txtBillingId.Text != "")
            {
                double number, amount, price;
                number = Convert.ToDouble(txtNumber.Text);
                price = Convert.ToDouble(txtUnitPrice.Text);
                amount = number * price;
                txtAmount.Text = amount.ToString();
                SqlCommand command2 = new SqlCommand("Insert into BillingDetail(ÜrünAdi,Adet,BirimFiyat,Tutar,FaturaId) values (@p1,@p2,@p3,@p4,@p5)", connect.connection());
                command2.Parameters.AddWithValue("@p1", txtProductName.Text);
                command2.Parameters.AddWithValue("@p2", txtNumber.Text);
                command2.Parameters.AddWithValue("@p3", txtUnitPrice.Text);
                command2.Parameters.AddWithValue("@p4", txtAmount.Text);
                command2.Parameters.AddWithValue("@p5", txtBillingId.Text);
                command2.ExecuteNonQuery();
                connect.connection().Close();
                List();
                MessageBox.Show("Fatura detayı sisteme eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clean();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Delete from BillingData where Id=@p1", connect.connection());
            command.Parameters.AddWithValue("@p1", txtId.Text);
            command.ExecuteNonQuery();
            connect.connection().Close();
            List();
            MessageBox.Show("Fatura bilgisi sistemden silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Clean();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update BillingData set SeriNo=@p1,SiraNo=@p2,VergiDairesi=@p3,Tarih=@p4,Saat=@p5,Alici=@p6,TeslimEden=@p7,TeslimAlan=@p8 where Id=@p9", connect.connection());
            command.Parameters.AddWithValue("@p1", txtSerialNo.Text);
            command.Parameters.AddWithValue("@p2", txtItemNo.Text);
            command.Parameters.AddWithValue("@p3", txtTaxOffice.Text);
            command.Parameters.AddWithValue("@p4", mskTxtDate.Text);
            command.Parameters.AddWithValue("@p5", mskTxtHour.Text);
            command.Parameters.AddWithValue("@p6", txtReceiver.Text);
            command.Parameters.AddWithValue("@p7", txtDeliverer.Text);
            command.Parameters.AddWithValue("@p8", txtRecipient.Text);
            command.Parameters.AddWithValue("@p9", txtId.Text);
            command.ExecuteNonQuery();
            connect.connection().Close();
            List();
            MessageBox.Show("Fatura bilgisi güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Clean();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Clean();
        }
    }
}
