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
    public partial class frmShowAllStaffMembers : Form
    {
        public frmShowAllStaffMembers()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmManager();
            f.Show();
        }

        private void gvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Staff_BL member = (Staff_BL)gvStaff.CurrentRow.DataBoundItem;
            if (gvStaff.Columns["Delete"].Index == e.ColumnIndex)
            {
                List<Staff_BL> lst = Staff_DL.deleteStaffFromList(member);
                Staff_DL.storeDataInFile(lst);
                dataBind();
                MessageBox.Show("Staff info is deleted Successfully");
            }
            else if (gvStaff.Columns["Edit"].Index == e.ColumnIndex)
            {
                frmEditStaff f = new frmEditStaff(member);
                f.ShowDialog();
                dataBind();
                MessageBox.Show("Staff info is edited Successfully");
            }

        }
        public void dataBind()
        {
            gvStaff.DataSource = null;
            gvStaff.DataSource = Staff_DL.getStaffList();
            gvStaff.Refresh();
        }

        private void frmShowAllStaffMembers_Load(object sender, EventArgs e)
        {
            List<Staff_BL> lst = Staff_DL.getStaffList();
            gvStaff.DataSource = lst;
        }
    }
}
