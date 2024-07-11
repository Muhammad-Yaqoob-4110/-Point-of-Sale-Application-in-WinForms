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
    public partial class frmAddNewStaffMember : Form
    {
        public frmAddNewStaffMember()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmManager();
            f.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if ((float.Parse(txtIDCard.Text) >= 0) && (float.Parse(txtSalary.Text) >= 0)  && (txtName.Text) != string.Empty)
                {
                    Staff_BL member = new Staff_BL();
                    member.Name = txtName.Text;
                    member.IdCard = txtIDCard.Text;
                    member.Salary = float.Parse(txtSalary.Text);
                    Staff_DL.addStaffToFile(member);
                    MessageBox.Show("Staff Member Info is added Successfully");
                }
                else
                {
                    throw new Exception("Enter Valid Information");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void frmAddNewStaffMember_Load(object sender, EventArgs e)
        {

        }
    }
}
