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
    public partial class frmPersonnel : Form
    {
        public frmPersonnel()
        {
            InitializeComponent();
        }

        SqlConnect connect = new SqlConnect();

        void List()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Personnel", connect.connection());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void CityList()
        {
            SqlCommand command = new SqlCommand("Select Il from Personnel", connect.connection());
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
            txtSurName.Text = "";
            txtJob.Text = "";
            mskTxtTCId.Text = "";
            mskTxtTel.Text = "";
            txtMail.Text = "";
            cmbCity.Text = "";
            cmbCounty.Text = "";
            rchTxtAddress.Text = "";
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
                txtName.Text = dr["Ad"].ToString();
                txtSurName.Text = dr["Soyad"].ToString();
                txtJob.Text = dr["Gorev"].ToString();
                mskTxtTel.Text = dr["Telefon"].ToString();
                mskTxtTCId.Text = dr["TCKimlikNo"].ToString();
                txtMail.Text = dr["Mail"].ToString();
                cmbCity.Text = dr["Il"].ToString();
                cmbCounty.Text = dr["Ilce"].ToString();
                rchTxtAddress.Text = dr["Adres"].ToString();
            }
        }

        private void frmPersonnel_Load(object sender, EventArgs e)
        {
            List();
            CityList();
            Clean();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Insert into Personnel(Ad,Soyad,Gorev,Telefon,TCKimlikNo,Mail,Il,Ilce,Adres) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9) ", connect.connection());
            command.Parameters.AddWithValue("@p1", txtName.Text);
            command.Parameters.AddWithValue("@p2", txtSurName.Text);
            command.Parameters.AddWithValue("@p3", txtJob.Text);
            command.Parameters.AddWithValue("@p4", mskTxtTel.Text);
            command.Parameters.AddWithValue("@p5", mskTxtTCId.Text);
            command.Parameters.AddWithValue("@p6", txtMail.Text);
            command.Parameters.AddWithValue("@p7", cmbCity.Text);
            command.Parameters.AddWithValue("@p8", cmbCounty.Text);
            command.Parameters.AddWithValue("@p9", rchTxtAddress.Text);
            command.ExecuteNonQuery();
            connect.connection().Close();
            List();
            MessageBox.Show("Personel sisteme eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clean();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Delete from Personnel where Id=@p1", connect.connection());
            command.Parameters.AddWithValue("@p1", txtId.Text);
            command.ExecuteNonQuery();
            connect.connection().Close();
            List();
            MessageBox.Show("Personel sistemden silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Clean();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update Personnel set Ad=@p1,Soyad=@p2,Gorev=@p3,Telefon=@p4,TCKimlikNo=@p5,Mail=@p6,Il=@p7,Ilce=@p8,Adres=@p9 where Id=@p10", connect.connection());
            command.Parameters.AddWithValue("@p1", txtName.Text);
            command.Parameters.AddWithValue("@p2", txtSurName.Text);
            command.Parameters.AddWithValue("@p3", txtJob.Text);
            command.Parameters.AddWithValue("@p4", mskTxtTel.Text);
            command.Parameters.AddWithValue("@p5", mskTxtTCId.Text);
            command.Parameters.AddWithValue("@p6", txtMail.Text);
            command.Parameters.AddWithValue("@p7", cmbCity.Text);
            command.Parameters.AddWithValue("@p8", cmbCounty.Text);
            command.Parameters.AddWithValue("@p9", rchTxtAddress.Text);
            command.Parameters.AddWithValue("@p10", txtId.Text);
            command.ExecuteNonQuery();
            connect.connection().Close();
            List();
            MessageBox.Show("Personel bilgisi güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Clean();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Clean();
        }
    }
}
