
namespace bilingSystemGUI
{
    partial class frmlogin
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnSignUP = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnRegister, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSignUP, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(394, 372);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.BackgroundImage = global::bilingSystemGUI.Properties.Resources.signIN;
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Location = new System.Drawing.Point(200, 3);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(191, 366);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnSignUP
            // 
            this.btnSignUP.BackColor = System.Drawing.Color.Transparent;
            this.btnSignUP.BackgroundImage = global::bilingSystemGUI.Properties.Resources.images;
            this.btnSignUP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSignUP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSignUP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUP.Location = new System.Drawing.Point(3, 3);
            this.btnSignUP.Name = "btnSignUP";
            this.btnSignUP.Size = new System.Drawing.Size(191, 366);
            this.btnSignUP.TabIndex = 3;
            this.btnSignUP.UseVisualStyleBackColor = false;
            this.btnSignUP.Click += new System.EventHandler(this.btnSignUP_Click);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 376);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmlogin";
            this.Text = "SignIN SignUP Form";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnSignUP;
    }
}

