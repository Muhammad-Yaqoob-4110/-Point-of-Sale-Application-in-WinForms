using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilingSystemGUI
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //SignIN
            this.Hide();
            Form f = new frmRegisterNewUser();
            f.Show();
        }

        private void btnSignUP_Click(object sender, EventArgs e)
        {
            //SignUP
            this.Hide();
            Form f = new frmSignUp();
            f.Show();
        }
    }
}
