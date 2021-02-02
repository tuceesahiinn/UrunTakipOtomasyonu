using _3MOtomotivSatisOtomasyonu.Bank;
using _3MOtomotivSatisOtomasyonu.Billing;
using _3MOtomotivSatisOtomasyonu.Company;
using _3MOtomotivSatisOtomasyonu.Note;
using _3MOtomotivSatisOtomasyonu.Stock;
using _3MOtomotivSatisOtomasyonu.Transactions;
using _3MOtomotivSatisOtomasyonu.Setting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3MOtomotivSatisOtomasyonu.Product;

namespace _3MOtomotivSatisOtomasyonu
{
    public partial class frmHomePage : Form
    {
        frmProduct fr;
        frmCustomer fr2;
        frmCompany fr3;
        frmPersonnel fr4;
        frmDirectory fr5;
        frmExpenditure fr6;
        frmBank fr7;
        frmBilling fr8;
        frmNote fr9;
        frmTransactions fr10;
        frmStock fr11;
        frmSetting fr12;

        public frmHomePage()
        {
            InitializeComponent();
        }
      
        private void btnProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null)
            {
                fr = new frmProduct();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void btnCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr2 == null)
            {
                fr2 = new frmCustomer();
                fr2.MdiParent = this;
                fr2.Show();
            }
        }

        private void btnCompany_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr3 == null)
            {
                fr3 = new frmCompany();
                fr3.MdiParent = this;
                fr3.Show();
            }
        }

        private void btnPersonnel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr4 == null)
            {
                fr4 = new frmPersonnel();
                fr4.MdiParent = this;
                fr4.Show();
            }
        }

        private void btnDirectory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr5 == null)
            {
                fr5 = new frmDirectory();
                fr5.MdiParent = this;
                fr5.Show();
            }
        }

        private void btnExpenditure_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr6 == null)
            {
                fr6 = new frmExpenditure();
                fr6.MdiParent = this;
                fr6.Show();
            }
        }

        private void btnBank_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr7 == null)
            {
                fr7 = new frmBank();
                fr7.MdiParent = this;
                fr7.Show();
            }
        }

        private void btnBilling_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr8 == null)
            {
                fr8 = new frmBilling();
                fr8.MdiParent = this;
                fr8.Show();
            }
        }

        private void btnNote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr9 == null)
            {
                fr9 = new frmNote();
                fr9.MdiParent = this;
                fr9.Show();
            }
        }

        private void btnTransaction_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr10 == null)
            {
                fr10 = new frmTransactions();
                fr10.MdiParent = this;
                fr10.Show();
            }
        }

        private void btnStock_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr11 == null)
            {
                fr11 = new frmStock();
                fr11.MdiParent = this;
                fr11.Show();
            }
        }

        private void btnSetting_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr12 == null)
            {
                fr12 = new frmSetting();
                fr12.MdiParent = this;
                fr12.Show();
            }
        }
    }
}
