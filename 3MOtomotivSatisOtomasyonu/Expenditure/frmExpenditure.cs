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

namespace _3MOtomotivSatisOtomasyonu.Company
{
    public partial class frmExpenditure : Form
    {
        public frmExpenditure()
        {
            InitializeComponent();
        }

        SqlConnect connect = new SqlConnect();

        void List()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Expenditure order by Id Asc", connect.connection());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void Clean()
        {
            txtId.Text = "";
            cmbMonth.Text = "";
            cmbYear.Text = "";
            txtElectricity.Text = "";
            txtWater.Text = "";
            txtNaturalGas.Text = "";
            txtInternet.Text = "";
            txtTelephone.Text = "";
            txtSalary.Text = "";
            txtExtra.Text = "";
            rchTxtDescription.Text = "";
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtId.Text = dr["Id"].ToString();
                cmbMonth.Text = dr["Ay"].ToString();
                cmbYear.Text = dr["Yil"].ToString();
                txtElectricity.Text = dr["Elektrik"].ToString();
                txtWater.Text = dr["Su"].ToString();
                txtNaturalGas.Text = dr["Dogalgaz"].ToString();
                txtInternet.Text = dr["Internet"].ToString();
                txtTelephone.Text = dr["Telefon"].ToString();
                txtSalary.Text = dr["Maas"].ToString();
                txtExtra.Text = dr["Ekstra"].ToString();
                rchTxtDescription.Text = dr["Aciklama"].ToString();
            }
        }

        private void frmExpenditure_Load(object sender, EventArgs e)
        {
            List();
            Clean();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Insert into Expenditure(Ay,Yil,Elektrik,Su,Dogalgaz,Internet,Telefon,Maas,Ekstra,Aciklama) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10) ", connect.connection());
            command.Parameters.AddWithValue("@p1", cmbMonth.Text);
            command.Parameters.AddWithValue("@p2", cmbYear.Text);
            command.Parameters.AddWithValue("@p3", decimal.Parse(txtElectricity.Text));
            command.Parameters.AddWithValue("@p4", decimal.Parse(txtWater.Text));
            command.Parameters.AddWithValue("@p5", decimal.Parse(txtNaturalGas.Text));
            command.Parameters.AddWithValue("@p6", decimal.Parse(txtInternet.Text));
            command.Parameters.AddWithValue("@p7", decimal.Parse(txtTelephone.Text));
            command.Parameters.AddWithValue("@p8", decimal.Parse(txtSalary.Text));
            command.Parameters.AddWithValue("@p9", decimal.Parse(txtExtra.Text));
            command.Parameters.AddWithValue("@p10", rchTxtDescription.Text);
            command.ExecuteNonQuery();
            connect.connection().Close();
            List();
            MessageBox.Show("Gider sisteme eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clean();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Delete from Expenditure where Id=@p1", connect.connection());
            command.Parameters.AddWithValue("@p1", txtId.Text);
            command.ExecuteNonQuery();
            connect.connection().Close();
            List();
            MessageBox.Show("Gider sistemden silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Clean();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update Expenditure set Ay=@p1,Yil=@p2,Elektrik=@p3,Su=@p4,Dogalgaz=@p5,Internet=@p6,Telefon=@p7,Maas=@p8,Ekstra=@p9,Aciklama=@p10 where Id=@p11", connect.connection());
            command.Parameters.AddWithValue("@p1", cmbMonth.Text);
            command.Parameters.AddWithValue("@p2", cmbYear.Text);
            command.Parameters.AddWithValue("@p3", decimal.Parse(txtElectricity.Text));
            command.Parameters.AddWithValue("@p4", decimal.Parse(txtWater.Text));
            command.Parameters.AddWithValue("@p5", decimal.Parse(txtNaturalGas.Text));
            command.Parameters.AddWithValue("@p6", decimal.Parse(txtInternet.Text));
            command.Parameters.AddWithValue("@p7", decimal.Parse(txtTelephone.Text));
            command.Parameters.AddWithValue("@p8", decimal.Parse(txtSalary.Text));
            command.Parameters.AddWithValue("@p9", decimal.Parse(txtExtra.Text));
            command.Parameters.AddWithValue("@p10", rchTxtDescription.Text);
            command.Parameters.AddWithValue("@p11", txtId.Text);
            command.ExecuteNonQuery();
            connect.connection().Close();
            List();
            MessageBox.Show("Gider bilgisi güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Clean();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Clean();
        }
    }
}
