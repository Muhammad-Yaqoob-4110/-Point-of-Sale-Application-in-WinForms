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
    public partial class frmRegisterNewUser : Form
    {
        public frmRegisterNewUser()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                string pwd = txtPassword.Text;
                string role = cbRole.Text;
                if (name == string.Empty || pwd == string.Empty || role == string.Empty)
                {
                    throw new Exception("Invalid Input");
                }
                else
                {
                    this.Hide();
                    MUserBL newUser = new MUserBL();
                    newUser.Name = name;
                    newUser.Password = pwd;
                    newUser.Role = role;
                    MUserDL.addIntoFile(newUser);
                    Form f = new frmCongragulations();
                    f.Show();
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f = new frmlogin();
            f.Show();
        }
    }
}
