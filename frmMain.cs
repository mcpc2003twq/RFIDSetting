using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RFIDsetting_test
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void btnUsb_Click(object sender, EventArgs e)
        {
            new frmMainUsb().ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
