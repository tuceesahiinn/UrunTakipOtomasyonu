using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3MOtomotivSatisOtomasyonu.Note
{
    public partial class frmNoteDetail : Form
    {
        public frmNoteDetail()
        {
            InitializeComponent();
        }

        public string text;

        private void frmNoteDetail_Load(object sender, EventArgs e)
        {
            rchTxtNoteDeatil.Text = text;
        }
    }
}
