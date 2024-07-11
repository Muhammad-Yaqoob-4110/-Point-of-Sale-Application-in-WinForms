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
    public partial class frmShowBuyedProducts : Form
    {
        public frmShowBuyedProducts()
        {
            InitializeComponent();
        }

        private void frmShowBuyedProducts_Load(object sender, EventArgs e)
        {
            gvBuyedProducts.DataSource = productC_DL.getBuyedProductList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmCustumer();
            f.Show();
        }

        private void btnAddMore_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmCustumer();
            f.Show();
        }

        private void gvBuyedProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                productC_BL product = (productC_BL)gvBuyedProducts.CurrentRow.DataBoundItem;
                if (gvBuyedProducts.Columns["Delete"].Index == e.ColumnIndex)
                {
                    List<productC_BL> lst = productC_DL.deleteProductFromBuyedList(product);
                    dataBind();
                    MessageBox.Show("Product is deleted Successfully");
                }
                else if (gvBuyedProducts.Columns["Edit_Quantity"].Index == e.ColumnIndex)
                {
                    frmEditBuyedProduct f = new frmEditBuyedProduct(product);
                    f.ShowDialog();
                    dataBind();
                    MessageBox.Show("Product is edited Successfully");
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        public void dataBind()
        {
            gvBuyedProducts.DataSource = null;
            gvBuyedProducts.DataSource = productC_DL.getBuyedProductList2();
            gvBuyedProducts.Refresh();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            float bill = productC_DL.getBill();
            MessageBox.Show("Your Bill is = " + bill + " Rupees");
            productC_DL.makeListEmpty();
            this.Close();
            Form f = new frmCustumer();
            f.Show();
        }
    }
}
