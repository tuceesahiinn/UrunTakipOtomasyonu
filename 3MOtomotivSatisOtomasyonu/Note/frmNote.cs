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

namespace _3MOtomotivSatisOtomasyonu.Note
{
    public partial class frmNote : Form
    {
        public frmNote()
        {
            InitializeComponent();
        }

        SqlConnect connect = new SqlConnect();

        void List()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Note", connect.connection());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void Clean()
        {
            txtId.Text = "";
            mskTxtDate.Text = "";
            mskTxtHour.Text = "";
            txtTitle.Text = "";
            txtPersonNameSurName.Text = "";
            txtCall.Text = "";
            rchTxtDetail.Text = "";
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtId.Text = dr["Id"].ToString();
                mskTxtDate.Text = dr["Tarih"].ToString();
                mskTxtHour.Text = dr["Saat"].ToString();
                txtTitle.Text = dr["Baslik"].ToString();
                txtPersonNameSurName.Text = dr["Olusturan"].ToString();
                txtCall.Text = dr["Hitap"].ToString();
                rchTxtDetail.Text = dr["Detay"].ToString();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmNoteDetail fr = new frmNoteDetail();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                fr.text = dr["Detay"].ToString();
            }
            fr.Show();
        }

        private void frmNote_Load(object sender, EventArgs e)
        {
            List();
            Clean();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Insert into Note(Tarih,Saat,Baslik,Olusturan,Hitap,Detay) values (@p1,@p2,@p3,@p4,@p5,@p6)", connect.connection());
            command.Parameters.AddWithValue("@p1", mskTxtDate.Text);
            command.Parameters.AddWithValue("@p2", mskTxtHour.Text);
            command.Parameters.AddWithValue("@p3", txtTitle.Text);
            command.Parameters.AddWithValue("@p4", txtPersonNameSurName.Text);
            command.Parameters.AddWithValue("@p5", txtCall.Text);
            command.Parameters.AddWithValue("@p6", rchTxtDetail.Text);
            command.ExecuteNonQuery();
            connect.connection().Close();
            List();
            MessageBox.Show("Not sisteme eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clean();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Delete from Note where Id=@p1", connect.connection());
            command.Parameters.AddWithValue("@p1", txtId.Text);
            command.ExecuteNonQuery();
            connect.connection().Close();
            List();
            MessageBox.Show("Not sistemden silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Clean();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update Note set Tarih=@p1,Saat=@p2,Baslik=@p3,Olusturan=@p4,Hitap=@p5,Detay=@p6 where Id=@p7", connect.connection());
            command.Parameters.AddWithValue("@p1", mskTxtDate.Text);
            command.Parameters.AddWithValue("@p2", mskTxtHour.Text);
            command.Parameters.AddWithValue("@p3", txtTitle.Text);
            command.Parameters.AddWithValue("@p4", txtPersonNameSurName.Text);
            command.Parameters.AddWithValue("@p5", txtCall.Text);
            command.Parameters.AddWithValue("@p6", rchTxtDetail.Text);
            command.Parameters.AddWithValue("@p7", txtId.Text);
            command.ExecuteNonQuery();
            connect.connection().Close();
            List();
            MessageBox.Show("Not bilgisi güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Clean();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Clean();
        }
    }
}
