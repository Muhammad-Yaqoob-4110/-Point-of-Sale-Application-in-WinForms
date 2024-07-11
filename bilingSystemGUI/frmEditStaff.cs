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
    public partial class frmEditStaff : Form
    {
        private Staff_BL previous;
        public frmEditStaff(Staff_BL previous)
        {
            InitializeComponent();
            this.previous = previous;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmEditStaff_Load(object sender, EventArgs e)
        {
            txtName.Text = previous.Name;
            txtIDCard.Text = previous.IdCard;
            txtSalary.Text = (previous.Salary).ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if ((float.Parse(txtSalary.Text) >= 0) && txtIDCard.Text != string.Empty && txtName.Text != string.Empty)
                {
                    Staff_BL staff = new Staff_BL();
                    staff.Name = txtName.Text;
                    staff.IdCard = txtIDCard.Text;
                    staff.Salary = float.Parse(txtSalary.Text);
                    List<Staff_BL> lst = Staff_DL.editStaffInList(previous, staff);
                    Staff_DL.storeDataInFile(lst);
                    this.Hide();
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
    }
}
