using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Purchase_Register
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void purchaseRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchaseRegister obj = new frmPurchaseRegister();
            obj.MdiParent = this;
            obj.Show();
        }

        private void distributorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDistributor obj = new frmDistributor();
            obj.MdiParent = this;
            obj.Show();
        }
    }
}
