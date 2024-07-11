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
    public partial class frmSendMessage : Form
    {
        private string path = "messageBox.txt";
        public frmSendMessage()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmManager();
            f.Show();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDate.Text !=string.Empty && txtMessage.Text !=string.Empty )
                {
                    Program.addMessageIntoFile(txtDate.Text, txtMessage.Text,path);
                    MessageBox.Show("Message is sent Successfully");
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
