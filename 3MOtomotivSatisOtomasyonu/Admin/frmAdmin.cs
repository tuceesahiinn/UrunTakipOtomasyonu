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

namespace _3MOtomotivSatisOtomasyonu.Admin
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        SqlConnect connect = new SqlConnect();
        private void btnLogIn_MouseHover(object sender, EventArgs e)
        {
            btnLogIn.BackColor = Color.Yellow;
        }

        private void btnLogIn_MouseLeave(object sender, EventArgs e)
        {
            btnLogIn.BackColor = Color.Green;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from Admin where KullaniciAdi=@p1 and Sifre=@p2", connect.connection());
            command.Parameters.AddWithValue("@p1", txtUserName.Text);
            command.Parameters.AddWithValue("@p2", txtPassword.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                frmHomePage fr = new frmHomePage();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre girdiniz! Lütfen tekrar deneyin!","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            connect.connection().Close();
        }
    }
}
