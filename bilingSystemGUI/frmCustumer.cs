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
    public partial class frmCustumer : Form
    {
        public int index;
        public frmCustumer()
        {
            InitializeComponent();
        }
        public frmCustumer(int index)
        {
            InitializeComponent();
            this.index = index;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmAlgorithms();
            f.Show();
        }

        private void frmCustumer_Load(object sender, EventArgs e)
        {
            if(index == 1)
            {
                /*bubble Sort*/
                List<productC_BL> lst = productC_DL.sorted_Algorithms(1);
                gvProducts.DataSource = lst;
            }
            else if(index == 2)
            {
                /*Selection Sort*/
                List<productC_BL> lst = productC_DL.sorted_Algorithms(2);
                gvProducts.DataSource = lst;
            }
            else if(index == 3)
            {
                /*Insertion Sort*/
                List<productC_BL> lst = productC_DL.sorted_Algorithms(3);
                gvProducts.DataSource = lst;
            }
            else if(index == 4)
            {
                /*Merge Sort*/
                List<productC_BL> lst = productC_DL.sorted_Algorithms(4);
                gvProducts.DataSource = lst;
            }
            else if (index == 5)
            {
                /*Merge Sort*/
                List<productC_BL> lst = productC_DL.sorted_Algorithms(5);
                gvProducts.DataSource = lst;
            }
            else if (index == 6)
            {
                /*Heap Sort*/
                List<productC_BL> lst = productC_DL.sorted_Algorithms(6);
                gvProducts.DataSource = lst;
            }
            else if (index == 7)
            {
                /*Heap Sort*/
                List<productC_BL> lst = productC_DL.sorted_Algorithms(7);
                gvProducts.DataSource = lst;
            }
            else if (index == 8)
            {
                /*Radix Sort*/
                List<productC_BL> lst = productC_DL.sorted_Algorithms(8);
                gvProducts.DataSource = lst;
            }
            else if (index == 9)
            {
                /*Radix Sort*/
                List<productC_BL> lst = productC_DL.sorted_Algorithms(9);
                gvProducts.DataSource = lst;
            }
        }

        private void gvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            productC_BL product = (productC_BL)gvProducts.CurrentRow.DataBoundItem;
            if (gvProducts.Columns["Buy"].Index == e.ColumnIndex)
            {
                productC_DL.buyerList(product);
                MessageBox.Show("Product is Added to Your List Successfully");
            }
        }
        public void dataBind()
        {
            gvProducts.DataSource = null;
            gvProducts.DataSource = productC_DL.getProductList();
            gvProducts.Refresh();
        }

        private void bynCalculateBill_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmShowBuyedProducts();
            f.Show();
        }
    }
}
