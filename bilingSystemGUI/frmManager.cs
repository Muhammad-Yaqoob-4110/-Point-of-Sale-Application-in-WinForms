using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bilingSystemGUI.BL;
using bilingSystemGUI.DL;
namespace bilingSystemGUI
{
    public partial class frmManager : Form
    {
        public frmManager()
        {
            InitializeComponent();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmAddNewProduct();
            f.Show();
        }

        private void viewAllProductsInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmViewAllProducts();
            f.Show();
        }

        private void deleteProductInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmDeleteProduct();
            f.Show();
        }

        private void editProductInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmjustEditProduct();
            f.Show();
        }

        private void productsQuantityRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmViewAllProducts();
            f.Show();
        }

        private void addStaffMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmAddNewStaffMember();
            f.Show();
        }

        private void viewAllStaffMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmShowAllStaffMembers();
            f.Show();
        }

        private void deleteStaffMemberInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmDeleteStaff();
            f.Show();
        }

        private void editStaffMemberInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmjustEditStaffInfo();
            f.Show();
        }

        private void sendMessageToStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmSendMessage();
            f.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmSignUp();
            f.Show();
        }
    }
}
