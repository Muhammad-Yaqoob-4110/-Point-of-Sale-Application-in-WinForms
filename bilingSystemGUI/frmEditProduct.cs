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
    public partial class frmEditProduct : Form
    {
        private productC_BL previous;
        public frmEditProduct(productC_BL previous)
        {
            InitializeComponent();
            this.previous = previous;
        }

        private void frmEditProduct_Load(object sender, EventArgs e)
        {
            txtName.Text = previous.Name;
            txtPrice.Text = (previous.Price).ToString();
            txtDiscount.Text = (previous.Discount).ToString();
            txtQuantity.Text = (previous.Quantity).ToString();

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if ((float.Parse(txtPrice.Text) >= 0) && (float.Parse(txtDiscount.Text) >= 0) && (float.Parse(txtQuantity.Text) >= 0) && (txtName.Text) != string.Empty)
                {
                    productC_BL product = new productC_BL();
                    product.Name = txtName.Text;
                    product.Price = float.Parse(txtPrice.Text);
                    product.Discount = float.Parse(txtDiscount.Text);
                    product.Quantity = float.Parse(txtQuantity.Text);
                    List<productC_BL>lst = productC_DL.editProductInList(previous,product);
                    productC_DL.storeDataInFile(lst);
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
