
namespace bilingSystemGUI
{
    partial class frmjustEditStaffInfo
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
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.gvStaff = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(668, 401);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 33;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gvStaff
            // 
            this.gvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit});
            this.gvStaff.Location = new System.Drawing.Point(1, 1);
            this.gvStaff.Name = "gvStaff";
            this.gvStaff.ReadOnly = true;
            this.gvStaff.Size = new System.Drawing.Size(798, 449);
            this.gvStaff.TabIndex = 32;
            this.gvStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvProducts_CellContentClick);
            // 
            // frmjustEditStaffInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gvStaff);
            this.Name = "frmjustEditStaffInfo";
            this.Text = "frmjustEditStaffInfo";
            this.Load += new System.EventHandler(this.frmjustEditStaffInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvStaff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView gvStaff;
    }
}