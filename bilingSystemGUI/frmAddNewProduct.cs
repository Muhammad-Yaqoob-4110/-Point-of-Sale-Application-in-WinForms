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
    public partial class frmAddNewProduct : Form
    {
        public frmAddNewProduct()
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
                if ((float.Parse(txtPrice.Text) >= 0) && (float.Parse(txtDiscount.Text) >= 0) && (float.Parse(txtQuantity.Text) >= 0) && (txtName.Text) != string.Empty)
                {
                    productC_BL product = new productC_BL();
                    product.Name = txtName.Text;
                    product.Price = float.Parse(txtPrice.Text);
                    product.Discount = float.Parse(txtDiscount.Text);
                    product.Quantity = float.Parse(txtQuantity.Text);
                    productC_DL.addProductToFile(product);
                    MessageBox.Show("Product Info is added Successfully");
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

        private void frmAddNewProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
