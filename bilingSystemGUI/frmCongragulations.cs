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
    public partial class frmCongragulations : Form
    {
        public frmCongragulations()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f = new frmlogin();
            f.Show();
        }
    }
}
