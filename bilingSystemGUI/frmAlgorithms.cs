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
    public partial class frmAlgorithms : Form
    {
        public frmAlgorithms()
        {
            InitializeComponent();
        }

        private void lbl_bubble_sort_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmCustumer(1);
            f.Show();
        }

        private void lbl_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmSignUp();
            f.Show();
        }

        private void lbl_selection_sort_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmCustumer(2);
            f.Show();
        }

        private void lbl_insertion_sort_Click(object sender, EventArgs e)
        {
            /*Insertion Sort*/
            this.Hide();
            Form f = new frmCustumer(3);
            f.Show();
        }

        private void lbl_merge_sort_Click(object sender, EventArgs e)
        {
            /*Merge Sort*/
            this.Hide();
            Form f = new frmCustumer(4);
            f.Show();
        }

        private void lbl_quick_sort_Click(object sender, EventArgs e)
        {
            /*Quick Sort*/
            this.Hide();
            Form f = new frmCustumer(5);
            f.Show();
        }

        private void lbl_heap_sort_Click(object sender, EventArgs e)
        {
            /*Heap Sort*/
            this.Hide();
            Form f = new frmCustumer(6);
            f.Show();
        }

        private void lbl_counting_sort_Click(object sender, EventArgs e)
        {
            /*Count Sort*/
            this.Hide();
            Form f = new frmCustumer(7);
            f.Show();
        }

        private void lbl_radix_sort_Click(object sender, EventArgs e)
        {
            /*Radix Sort*/
            this.Hide();
            Form f = new frmCustumer(8);
            f.Show();
        }

        private void lbl_bucket_sort_Click(object sender, EventArgs e)
        {
            /*Bucket Sort*/
            this.Hide();
            Form f = new frmCustumer(9);
            f.Show();
        }
    }
}
