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
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmlogin();
            f.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == string.Empty || txtPassword.Text == string.Empty)
                {
                    throw new Exception("Invalid Input");

                }
                else
                {
                    MUserBL newUser = new MUserBL(txtName.Text, txtPassword.Text);
                    MUserBL userInfo = MUserDL.checkFromFile(newUser);
                    if (userInfo != null)
                    {
                        //Valid User
                        if(userInfo.Role == "Custumer")
                        {
                            //custumer
                            this.Hide();
                            /*Form f = new frmCustumer();
                            f.Show();*/
                            /*ab krna ye hi keh ham nai aik form banana hi. jis pai tamam algorithms 
                             houn gai aur user un mai sai select karay ga. phir show karna result. bas.*/
                            Form f = new frmAlgorithms();
                            f.Show();
                        }
                        else if(userInfo.Role == "Manager")
                        {
                            //manager
                            this.Hide();
                            Form f = new frmManager();
                            f.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid User");
                    }
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }
    }
}
