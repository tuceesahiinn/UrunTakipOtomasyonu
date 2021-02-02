using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

namespace _3MOtomotivSatisOtomasyonu
{
    public partial class frmMail : Form
    {
        public frmMail()
        {
            InitializeComponent();
        }

        public string mail;

        private void frmMail_Load(object sender, EventArgs e)
        {
            txtMail.Text = mail;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SmtpClient smtpClient = new SmtpClient("mail.domain.com", 587);
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new System.Net.NetworkCredential("user@domain.com", "sifre");
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = true;

            MailMessage mail = new MailMessage();

            mail.From = new MailAddress("user@domain.com", "User");
            mail.To.Add(new MailAddress("amadertem@gmail.com"));
            ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
            smtpClient.Send(mail);

            //MailMessage mailMessage = new MailMessage();
            //SmtpClient client = new SmtpClient();
            //client.Credentials = new System.Net.NetworkCredential("Mail", "Şifre");
            //client.Port = 587;
            //client.Host = "mail.gmail.com";
            //client.EnableSsl = true;
            //mailMessage.To.Add(txtMail.Text);
            //mailMessage.From = new MailAddress("Mail");
            //mailMessage.Subject = txtSubject.Text;
            //mailMessage.Body = rchTxtMessage.Text;
            //client.Send(mailMessage);

        }
    }
}
