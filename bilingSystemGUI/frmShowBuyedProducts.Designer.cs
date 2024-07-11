
namespace bilingSystemGUI
{
    partial class frmShowBuyedProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gvBuyedProducts = new System.Windows.Forms.DataGridView();
            this.Edit_Quantity = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnAddMore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvBuyedProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // gvBuyedProducts
            // 
            this.gvBuyedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBuyedProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit_Quantity,
            this.Delete});
            this.gvBuyedProducts.Location = new System.Drawing.Point(12, 12);
            this.gvBuyedProducts.Name = "gvBuyedProducts";
            this.gvBuyedProducts.ReadOnly = true;
            this.gvBuyedProducts.Size = new System.Drawing.Size(787, 436);
            this.gvBuyedProducts.TabIndex = 0;
            this.gvBuyedProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvBuyedProducts_CellContentClick);
            // 
            // Edit_Quantity
            // 
            this.Edit_Quantity.HeaderText = "Edit_Quantity";
            this.Edit_Quantity.Name = "Edit_Quantity";
            this.Edit_Quantity.ReadOnly = true;
            this.Edit_Quantity.Text = "Edit_Quantity";
            this.Edit_Quantity.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(602, 333);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnBill
            // 
            this.btnBill.Location = new System.Drawing.Point(713, 333);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(75, 23);
            this.btnBill.TabIndex = 2;
            this.btnBill.Text = "Bill";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnAddMore
            // 
            this.btnAddMore.Location = new System.Drawing.Point(602, 281);
            this.btnAddMore.Name = "btnAddMore";
            this.btnAddMore.Size = new System.Drawing.Size(186, 23);
            this.btnAddMore.TabIndex = 3;
            this.btnAddMore.Text = "Add More Products";
            this.btnAddMore.UseVisualStyleBackColor = true;
            this.btnAddMore.Click += new System.EventHandler(this.btnAddMore_Click);
            // 
            // frmShowBuyedProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddMore);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gvBuyedProducts);
            this.Name = "frmShowBuyedProducts";
            this.Text = "frmShowBuyedProducts";
            this.Load += new System.EventHandler(this.frmShowBuyedProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvBuyedProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvBuyedProducts;
        private System.Windows.Forms.DataGridViewButtonColumn Edit_Quantity;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnAddMore;
    }
}