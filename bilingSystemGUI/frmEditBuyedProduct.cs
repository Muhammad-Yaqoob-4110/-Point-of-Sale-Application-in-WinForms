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
    public partial class frmEditBuyedProduct : Form
    {
        private productC_BL previous;
        public frmEditBuyedProduct(productC_BL previous)
        {
            InitializeComponent();
            this.previous = previous;
        }

        private void frmEditBuyedProduct_Load(object sender, EventArgs e)
        {
            txtQuantity.Text = (previous.Quantity).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (float.Parse(txtQuantity.Text) > 0)
                {
                    productC_BL product = new productC_BL();
                    product.Name = previous.Name;
                    product.Price = previous.Price;
                    product.Quantity = float.Parse(txtQuantity.Text);
                    product.Discount = previous.Discount;
                    List<productC_BL>lst = productC_DL.editProductInBuyedList(previous, product);
                    productC_DL.storeBuyedDataINList(lst);
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
