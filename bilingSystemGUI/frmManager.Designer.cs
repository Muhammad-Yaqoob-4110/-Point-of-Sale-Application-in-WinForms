
namespace bilingSystemGUI
{
    partial class frmManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProductInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProductInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllProductsInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsQuantityRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStaffMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editStaffMemberInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStaffMemberInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllStaffMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendMessageToStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBack = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(477, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsInfoToolStripMenuItem,
            this.staffInfoToolStripMenuItem});
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // productsInfoToolStripMenuItem
            // 
            this.productsInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductToolStripMenuItem,
            this.editProductInfoToolStripMenuItem,
            this.deleteProductInfoToolStripMenuItem,
            this.viewAllProductsInfoToolStripMenuItem,
            this.productsQuantityRecordToolStripMenuItem});
            this.productsInfoToolStripMenuItem.Name = "productsInfoToolStripMenuItem";
            this.productsInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productsInfoToolStripMenuItem.Text = "Products Info";
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.addProductToolStripMenuItem.Text = "Add Product Info";
            this.addProductToolStripMenuItem.Click += new System.EventHandler(this.addProductToolStripMenuItem_Click);
            // 
            // editProductInfoToolStripMenuItem
            // 
            this.editProductInfoToolStripMenuItem.Name = "editProductInfoToolStripMenuItem";
            this.editProductInfoToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.editProductInfoToolStripMenuItem.Text = "Edit Product Info";
            this.editProductInfoToolStripMenuItem.Click += new System.EventHandler(this.editProductInfoToolStripMenuItem_Click);
            // 
            // deleteProductInfoToolStripMenuItem
            // 
            this.deleteProductInfoToolStripMenuItem.Name = "deleteProductInfoToolStripMenuItem";
            this.deleteProductInfoToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.deleteProductInfoToolStripMenuItem.Text = "Delete Product Info";
            this.deleteProductInfoToolStripMenuItem.Click += new System.EventHandler(this.deleteProductInfoToolStripMenuItem_Click);
            // 
            // viewAllProductsInfoToolStripMenuItem
            // 
            this.viewAllProductsInfoToolStripMenuItem.Name = "viewAllProductsInfoToolStripMenuItem";
            this.viewAllProductsInfoToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.viewAllProductsInfoToolStripMenuItem.Text = "View All Products Info";
            this.viewAllProductsInfoToolStripMenuItem.Click += new System.EventHandler(this.viewAllProductsInfoToolStripMenuItem_Click);
            // 
            // productsQuantityRecordToolStripMenuItem
            // 
            this.productsQuantityRecordToolStripMenuItem.Name = "productsQuantityRecordToolStripMenuItem";
            this.productsQuantityRecordToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.productsQuantityRecordToolStripMenuItem.Text = "Products Quantity Record";
            this.productsQuantityRecordToolStripMenuItem.Click += new System.EventHandler(this.productsQuantityRecordToolStripMenuItem_Click);
            // 
            // staffInfoToolStripMenuItem
            // 
            this.staffInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStaffMemberToolStripMenuItem,
            this.editStaffMemberInfoToolStripMenuItem,
            this.deleteStaffMemberInfoToolStripMenuItem,
            this.viewAllStaffMembersToolStripMenuItem,
            this.sendMessageToStaffToolStripMenuItem});
            this.staffInfoToolStripMenuItem.Name = "staffInfoToolStripMenuItem";
            this.staffInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.staffInfoToolStripMenuItem.Text = "Staff Info";
            // 
            // addStaffMemberToolStripMenuItem
            // 
            this.addStaffMemberToolStripMenuItem.Name = "addStaffMemberToolStripMenuItem";
            this.addStaffMemberToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.addStaffMemberToolStripMenuItem.Text = "Add Staff Member";
            this.addStaffMemberToolStripMenuItem.Click += new System.EventHandler(this.addStaffMemberToolStripMenuItem_Click);
            // 
            // editStaffMemberInfoToolStripMenuItem
            // 
            this.editStaffMemberInfoToolStripMenuItem.Name = "editStaffMemberInfoToolStripMenuItem";
            this.editStaffMemberInfoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.editStaffMemberInfoToolStripMenuItem.Text = "Edit Staff Member Info";
            this.editStaffMemberInfoToolStripMenuItem.Click += new System.EventHandler(this.editStaffMemberInfoToolStripMenuItem_Click);
            // 
            // deleteStaffMemberInfoToolStripMenuItem
            // 
            this.deleteStaffMemberInfoToolStripMenuItem.Name = "deleteStaffMemberInfoToolStripMenuItem";
            this.deleteStaffMemberInfoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.deleteStaffMemberInfoToolStripMenuItem.Text = "Delete Staff Member Info";
            this.deleteStaffMemberInfoToolStripMenuItem.Click += new System.EventHandler(this.deleteStaffMemberInfoToolStripMenuItem_Click);
            // 
            // viewAllStaffMembersToolStripMenuItem
            // 
            this.viewAllStaffMembersToolStripMenuItem.Name = "viewAllStaffMembersToolStripMenuItem";
            this.viewAllStaffMembersToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.viewAllStaffMembersToolStripMenuItem.Text = "View All Staff Members";
            this.viewAllStaffMembersToolStripMenuItem.Click += new System.EventHandler(this.viewAllStaffMembersToolStripMenuItem_Click);
            // 
            // sendMessageToStaffToolStripMenuItem
            // 
            this.sendMessageToStaffToolStripMenuItem.Name = "sendMessageToStaffToolStripMenuItem";
            this.sendMessageToStaffToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.sendMessageToStaffToolStripMenuItem.Text = "Send Message to Staff";
            this.sendMessageToStaffToolStripMenuItem.Click += new System.EventHandler(this.sendMessageToStaffToolStripMenuItem_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(379, 196);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 32;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 231);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmManager";
            this.Text = "frmManager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProductInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteProductInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllProductsInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsQuantityRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStaffMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editStaffMemberInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStaffMemberInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllStaffMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendMessageToStaffToolStripMenuItem;
        private System.Windows.Forms.Button btnBack;
    }
}