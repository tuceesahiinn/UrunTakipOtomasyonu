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

namespace _3MOtomotivSatisOtomasyonu.Bank
{
    public partial class frmBank : Form
    {
        public frmBank()
        {
            InitializeComponent();
        }

        SqlConnect connect = new SqlConnect();

        void List()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute BankInformation", connect.connection());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void CityList()
        {
            SqlCommand command = new SqlCommand("Select Il from City", connect.connection());
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                cmbCity.Properties.Items.Add(dr[0]);
            }
            connect.connection().Close();
        }

        void CompanyList()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Id,FirmaAdi from Company", connect.connection());
            da.Fill(dt);
            lueCompany.Properties.ValueMember = "Id";
            lueCompany.Properties.DisplayMember = "FirmaAdi";
            lueCompany.Properties.DataSource = dt;
        }

        void Clean()
        {
            txtId.Text = "";
            txtName.Text = "";
            cmbCity.Text = "";
            cmbCounty.Text = "";
            txtBranchOffice.Text = "";
            mskTxtIBANNo.Text = "";
            mskTxtAccountNo.Text = "";
            txtCompetentNameSurName.Text = "";
            mskTxtTel.Text = "";
            mskTxtDate.Text = "";
            txtAccountType.Text = "";
            lueCompany.Text = "";
        }

        private void cmbCity_Properties_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCounty.Properties.Items.Clear();
            SqlCommand command = new SqlCommand("Select Ilce from County where Il=@p1", connect.connection());
            command.Parameters.AddWithValue("@p1", cmbCity.SelectedIndex + 1);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                cmbCounty.Properties.Items.Add(dr[0]);
            }
            connect.connection().Close();
        }

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtId.Text = dr["Id"].ToString();
                txtName.Text = dr["BankaAdi"].ToString();
                cmbCity.Text = dr["Il"].ToString();
                cmbCounty.Text = dr["Ilce"].ToString();
                txtBranchOffice.Text = dr["Sube"].ToString();
                mskTxtIBANNo.Text = dr["IBANNo"].ToString();
                mskTxtAccountNo.Text = dr["HesapNo"].ToString();
                txtCompetentNameSurName.Text = dr["YetkiliAdSoyad"].ToString();
                mskTxtTel.Text = dr["Telefon"].ToString();
                mskTxtDate.Text = dr["Tarih"].ToString();
                txtAccountType.Text = dr["HesapTuru"].ToString();
                lueCompany.EditValue=dr["FirmaAdi"].ToString();
            }
        }

        private void frmBank_Load(object sender, EventArgs e)
        {
            List();
            CityList();
            CompanyList();
            Clean();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Insert into Bank(BankaAdi,Il,Ilce,Sube,IBANNo,HesapNo,YetkiliAdSoyad,Telefon,Tarih,HesapTuru,FirmaId) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11) ", connect.connection());
            command.Parameters.AddWithValue("@p1", txtName.Text);
            command.Parameters.AddWithValue("@p2", cmbCity.Text);
            command.Parameters.AddWithValue("@p3", cmbCounty.Text);
            command.Parameters.AddWithValue("@p4", txtBranchOffice.Text);
            command.Parameters.AddWithValue("@p5", mskTxtIBANNo.Text);
            command.Parameters.AddWithValue("@p6", mskTxtAccountNo.Text);
            command.Parameters.AddWithValue("@p7", txtCompetentNameSurName.Text);
            command.Parameters.AddWithValue("@p8", mskTxtTel.Text);
            command.Parameters.AddWithValue("@p9", mskTxtDate.Text);
            command.Parameters.AddWithValue("@p10", txtAccountType.Text);
            command.Parameters.AddWithValue("@p11", lueCompany.EditValue);
            command.ExecuteNonQuery();
            connect.connection().Close();
            List();
            MessageBox.Show("Banka sisteme eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clean();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Delete from Bank where Id=@p1", connect.connection());
            command.Parameters.AddWithValue("@p1", txtId.Text);
            command.ExecuteNonQuery();
            connect.connection().Close();
            List();
            MessageBox.Show("Banka sistemden silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Clean();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update Bank set BankaAdi=@p1,Il=@p2,Ilce=@p3,Sube=@p4,IBANNo=@p5,HesapNo=@p6,YetkiliAdSoyad=@p7,Telefon=@p8,Tarih=@p9,HesapTuru=@p10,FirmaId=@p11 where Id=@p12", connect.connection());
            command.Parameters.AddWithValue("@p1", txtName.Text);
            command.Parameters.AddWithValue("@p2", cmbCity.Text);
            command.Parameters.AddWithValue("@p3", cmbCounty.Text);
            command.Parameters.AddWithValue("@p4", txtBranchOffice.Text);
            command.Parameters.AddWithValue("@p5", mskTxtIBANNo.Text);
            command.Parameters.AddWithValue("@p6", mskTxtAccountNo.Text);
            command.Parameters.AddWithValue("@p7", txtCompetentNameSurName.Text);
            command.Parameters.AddWithValue("@p8", mskTxtTel.Text);
            command.Parameters.AddWithValue("@p9", mskTxtDate.Text);
            command.Parameters.AddWithValue("@p10", txtAccountType.Text);
            command.Parameters.AddWithValue("@p11", lueCompany.EditValue);
            command.Parameters.AddWithValue("@p12", txtId.Text);
            command.ExecuteNonQuery();
            connect.connection().Close();
            List();
            MessageBox.Show("Banka bilgisi güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Clean();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Clean();
        }
    }
}
