
namespace bilingSystemGUI
{
    partial class frmCongragulations
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
            this.btnNext = new System.Windows.Forms.Button();
            this.lblCongrats = new System.Windows.Forms.Label();
            this.lblCongragulation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(547, 224);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblCongrats
            // 
            this.lblCongrats.AutoSize = true;
            this.lblCongrats.Font = new System.Drawing.Font("Ravie", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lblCongrats.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCongrats.Location = new System.Drawing.Point(132, 62);
            this.lblCongrats.Name = "lblCongrats";
            this.lblCongrats.Size = new System.Drawing.Size(323, 36);
            this.lblCongrats.TabIndex = 13;
            this.lblCongrats.Text = "Congragulations";
            // 
            // lblCongragulation
            // 
            this.lblCongragulation.AutoSize = true;
            this.lblCongragulation.Font = new System.Drawing.Font("Ravie", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lblCongragulation.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCongragulation.Location = new System.Drawing.Point(6, 121);
            this.lblCongragulation.Name = "lblCongragulation";
            this.lblCongragulation.Size = new System.Drawing.Size(616, 36);
            this.lblCongragulation.TabIndex = 12;
            this.lblCongragulation.Text = "New User is Added Successfully";
            // 
            // frmCongragulations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 269);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblCongrats);
            this.Controls.Add(this.lblCongragulation);
            this.Name = "frmCongragulations";
            this.Text = "frmCongragulations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblCongrats;
        private System.Windows.Forms.Label lblCongragulation;
    }
}