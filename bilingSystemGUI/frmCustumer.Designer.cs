
namespace bilingSystemGUI
{
    partial class frmCustumer
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
            this.lblAddNewUser = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.gvProducts = new System.Windows.Forms.DataGridView();
            this.Buy = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bynCalculateBill = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddNewUser
            // 
            this.lblAddNewUser.AutoSize = true;
            this.lblAddNewUser.Font = new System.Drawing.Font("Ravie", 30F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lblAddNewUser.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblAddNewUser.Location = new System.Drawing.Point(23, 20);
            this.lblAddNewUser.Name = "lblAddNewUser";
            this.lblAddNewUser.Size = new System.Drawing.Size(733, 54);
            this.lblAddNewUser.TabIndex = 27;
            this.lblAddNewUser.Text = "Welcome to SuperMarket";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(668, 411);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 13);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // gvProducts
            // 
            this.gvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Buy});
            this.gvProducts.Location = new System.Drawing.Point(1, 77);
            this.gvProducts.Name = "gvProducts";
            this.gvProducts.ReadOnly = true;
            this.gvProducts.Size = new System.Drawing.Size(798, 373);
            this.gvProducts.TabIndex = 30;
            this.gvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvProducts_CellContentClick);
            // 
            // Buy
            // 
            this.Buy.HeaderText = "Buy";
            this.Buy.Name = "Buy";
            this.Buy.ReadOnly = true;
            this.Buy.Text = "Buy";
            this.Buy.UseColumnTextForButtonValue = true;
            // 
            // bynCalculateBill
            // 
            this.bynCalculateBill.Location = new System.Drawing.Point(704, 382);
            this.bynCalculateBill.Name = "bynCalculateBill";
            this.bynCalculateBill.Size = new System.Drawing.Size(75, 23);
            this.bynCalculateBill.TabIndex = 32;
            this.bynCalculateBill.Text = "Next";
            this.bynCalculateBill.UseVisualStyleBackColor = true;
            this.bynCalculateBill.Click += new System.EventHandler(this.bynCalculateBill_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(593, 382);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 33;
            this.btnExit.Text = "Back";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmCustumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.bynCalculateBill);
            this.Controls.Add(this.gvProducts);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblAddNewUser);
            this.Name = "frmCustumer";
            this.Text = "frmCustumer";
            this.Load += new System.EventHandler(this.frmCustumer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddNewUser;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView gvProducts;
        private System.Windows.Forms.Button bynCalculateBill;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewButtonColumn Buy;
    }
}