using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            frmMember frmMember = new frmMember();
            frmMember.Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            frmOrder frmOrder = new frmOrder();
            frmOrder.Show();
            this.Hide();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            frmProduct frmProduct = new frmProduct();
            frmProduct.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            // Close();
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
