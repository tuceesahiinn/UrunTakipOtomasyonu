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

namespace _3MOtomotivSatisOtomasyonu
{
    public partial class frmCompany : Form
    {
        public frmCompany()
        {
            InitializeComponent();
        }

        SqlConnect connect = new SqlConnect();

        void List()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Company", connect.connection());
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

        void Clean()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtSector.Text = "";
            txtCompetentNameSurName.Text = "";
            txtCompetentStatu.Text = "";
            mskTxtCompetentTcId.Text = "";
            mskTxtTel1.Text = "";
            mskTxtTel2.Text = "";
            mskTxtTel3.Text = "";
            mskTxtFax.Text = "";
            txtMail.Text = "";
            cmbCity.Text = "";
            cmbCounty.Text = "";
            rchTxtAddress.Text = "";
            txtTaxOffice.Text = "";
            txtPrivateCode1.Text = "";
            txtPrivateCode2.Text = "";
            txtPrivateCode3.Text = "";
        }

        void InstantCodeDescription()
        {
            SqlCommand command = new SqlCommand("Select [FirmaKod1] from PrivateCode", connect.connection());
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                rchTxtPrivateCode1.Text = dr[0].ToString();
            }
            connect.connection().Close();
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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtId.Text = dr["Id"].ToString();
                txtName.Text = dr["FirmaAdi"].ToString();
                txtSector.Text = dr["Sektor"].ToString();
                txtCompetentNameSurName.Text = dr["YetkiliAdSoyad"].ToString();
                txtCompetentStatu.Text = dr["YetkiliStatu"].ToString();
                mskTxtCompetentTcId.Text = dr["YetkiliTCKimlikNo"].ToString();
                mskTxtTel1.Text = dr["Telefon1"].ToString();
                mskTxtTel2.Text = dr["Telefon2"].ToString();
                mskTxtTel3.Text = dr["Telefon3"].ToString();
                mskTxtFax.Text = dr["Fax"].ToString();
                txtMail.Text = dr["Mail"].ToString();
                cmbCity.Text = dr["Il"].ToString();
                cmbCounty.Text = dr["Ilce"].ToString();
                rchTxtAddress.Text = dr["Adres"].ToString();
                txtTaxOffice.Text = dr["VergiDairesi"].ToString();
                txtPrivateCode1.Text = dr["OzelKod1"].ToString();
                txtPrivateCode2.Text = dr["OzelKod2"].ToString();
                txtPrivateCode3.Text = dr["OzelKod3"].ToString();
            }
        }

        private void frmCompany_Load(object sender, EventArgs e)
        {
            List();
            CityList();
            Clean();
            InstantCodeDescription();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Insert into Company(FirmaAdi,Sektor,YetkiliAdSoyad,YetkiliStatu,YetkiliTCKimlikNo,Telefon1,Telefon2,Telefon3,Fax,Mail,Il,Ilce,Adres,VergiDairesi,OzelKod1,OzelKod2,OzelKod3) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17) ", connect.connection());
            command.Parameters.AddWithValue("@p1", txtName.Text);
            command.Parameters.AddWithValue("@p2", txtSector.Text);
            command.Parameters.AddWithValue("@p3", txtCompetentNameSurName.Text);
            command.Parameters.AddWithValue("@p4", txtCompetentStatu.Text);
            command.Parameters.AddWithValue("@p5", mskTxtCompetentTcId.Text);
            command.Parameters.AddWithValue("@p6", mskTxtTel1.Text);
            command.Parameters.AddWithValue("@p7", mskTxtTel2.Text);
            command.Parameters.AddWithValue("@p8", mskTxtTel3.Text);
            command.Parameters.AddWithValue("@p9", mskTxtFax.Text);
            command.Parameters.AddWithValue("@p10", txtMail.Text);
            command.Parameters.AddWithValue("@p11", cmbCity.Text);
            command.Parameters.AddWithValue("@p12", cmbCounty.Text);
            command.Parameters.AddWithValue("@p13", rchTxtAddress.Text);
            command.Parameters.AddWithValue("@p14", txtTaxOffice.Text);
            command.Parameters.AddWithValue("@p15", txtPrivateCode1.Text);
            command.Parameters.AddWithValue("@p16", txtPrivateCode2.Text);
            command.Parameters.AddWithValue("@p17", txtPrivateCode3.Text);
            command.ExecuteNonQuery();
            connect.connection().Close();
            List();
            MessageBox.Show("Firma sisteme eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clean();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Delete from Company where Id=@p1", connect.connection());
            command.Parameters.AddWithValue("@p1", txtId.Text);
            command.ExecuteNonQuery();
            connect.connection().Close();
            List();
            MessageBox.Show("Firma sistemden silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Clean();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update Company set FirmaAdi=@p1,Sektor=@p2,YetkiliAdSoyad=@p3,YetkiliStatu=@p4,YetkiliTCKimlikNo=@p5,Telefon1=@p6,Telefon2=@p7,Telefon3=@p8,Fax=@p9,Mail=@p10,Il=@p11,Ilce=@p12,Adres=@p13,VergiDairesi=@p14,OzelKod1=@p15,OzelKod2=@p16,OzelKod3=@p17 where Id=@p18", connect.connection());
            command.Parameters.AddWithValue("@p1", txtName.Text);
            command.Parameters.AddWithValue("@p2", txtSector.Text);
            command.Parameters.AddWithValue("@p3", txtCompetentNameSurName.Text);
            command.Parameters.AddWithValue("@p4", txtCompetentStatu.Text);
            command.Parameters.AddWithValue("@p5", mskTxtCompetentTcId.Text);
            command.Parameters.AddWithValue("@p6", mskTxtTel1.Text);
            command.Parameters.AddWithValue("@p7", mskTxtTel2.Text);
            command.Parameters.AddWithValue("@p8", mskTxtTel3.Text);
            command.Parameters.AddWithValue("@p9", mskTxtFax.Text);
            command.Parameters.AddWithValue("@p10", txtMail.Text);          
            command.Parameters.AddWithValue("@p11", cmbCity.Text);
            command.Parameters.AddWithValue("@p12", cmbCounty.Text);
            command.Parameters.AddWithValue("@p13", rchTxtAddress.Text);
            command.Parameters.AddWithValue("@p14", txtTaxOffice.Text);
            command.Parameters.AddWithValue("@p15", txtPrivateCode1.Text);
            command.Parameters.AddWithValue("@p16", txtPrivateCode2.Text);
            command.Parameters.AddWithValue("@p17", txtPrivateCode3.Text);
            command.Parameters.AddWithValue("@p18", txtId.Text);
            command.ExecuteNonQuery();
            connect.connection().Close();
            List();
            MessageBox.Show("Firma bilgisi güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Clean();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Clean();
        }
    }
}
