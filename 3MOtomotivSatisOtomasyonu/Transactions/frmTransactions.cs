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

namespace _3MOtomotivSatisOtomasyonu.Transactions
{
    public partial class frmTransactions : Form
    {
        public frmTransactions()
        {
            InitializeComponent();
        }

        SqlConnect connect = new SqlConnect();

        void TransactionCustomer()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute TransactionCustomerProcedure", connect.connection());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void TransactionCompany()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute TransactionCompanyProcedure", connect.connection());
            da.Fill(dt);
            gridControl2.DataSource = dt;
        }

        private void frmTransactions_Load(object sender, EventArgs e)
        {
            TransactionCustomer();
            TransactionCompany();
        }
    }
}
