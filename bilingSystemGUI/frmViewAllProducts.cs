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
    public partial class frmViewAllProducts : Form
    {
        public frmViewAllProducts()
        {
            InitializeComponent();
        }

        private void frmViewAllProducts_Load(object sender, EventArgs e)
        {
            List<productC_BL> lst = productC_DL.getProductList();
            gvProducts.DataSource = lst;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmManager();
            f.Show();
        }

        private void gvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            productC_BL product = (productC_BL)gvProducts.CurrentRow.DataBoundItem;
            if (gvProducts.Columns["Delete"].Index == e.ColumnIndex)
            {
                List<productC_BL> lst =  productC_DL.deleteProductFromList(product);
                productC_DL.storeDataInFile(lst);
                dataBind();
                MessageBox.Show("Product is deleted Successfully");
            }
            else if(gvProducts.Columns["Edit"].Index == e.ColumnIndex)
            {
                frmEditProduct f = new frmEditProduct(product);
                f.ShowDialog();
                dataBind();
                MessageBox.Show("Product is edited Successfully");
            }
        }

        public void dataBind()
        {
            gvProducts.DataSource = null;
            gvProducts.DataSource = productC_DL.getProductList();
            gvProducts.Refresh();
        }
    }
}
