namespace pharmacyproject
{
    partial class administrator
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
            this.sidepanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnupdatemedicine = new System.Windows.Forms.Button();
            this.btnviewmedicine = new System.Windows.Forms.Button();
            this.tnviewuser = new System.Windows.Forms.Button();
            this.btnaddmedicine = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnadduser = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidepanel
            // 
            this.sidepanel.Location = new System.Drawing.Point(246, 0);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(582, 498);
            this.sidepanel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Administrator Dashboard";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.mainPanel);
            this.panel1.Controls.Add(this.sidepanel);
            this.panel1.Controls.Add(this.btnupdatemedicine);
            this.panel1.Controls.Add(this.btnviewmedicine);
            this.panel1.Controls.Add(this.tnviewuser);
            this.panel1.Controls.Add(this.btnaddmedicine);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btnadduser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 511);
            this.panel1.TabIndex = 5;
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(246, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(629, 509);
            this.mainPanel.TabIndex = 6;
            // 
            // btnupdatemedicine
            // 
            this.btnupdatemedicine.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnupdatemedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdatemedicine.ForeColor = System.Drawing.Color.Red;
            this.btnupdatemedicine.Location = new System.Drawing.Point(26, 348);
            this.btnupdatemedicine.Name = "btnupdatemedicine";
            this.btnupdatemedicine.Size = new System.Drawing.Size(193, 58);
            this.btnupdatemedicine.TabIndex = 8;
            this.btnupdatemedicine.Text = "Update/Delete Medicine";
            this.btnupdatemedicine.UseVisualStyleBackColor = false;
            this.btnupdatemedicine.Click += new System.EventHandler(this.btnupdatemedicine_Click);
            // 
            // btnviewmedicine
            // 
            this.btnviewmedicine.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnviewmedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewmedicine.ForeColor = System.Drawing.Color.Red;
            this.btnviewmedicine.Location = new System.Drawing.Point(26, 275);
            this.btnviewmedicine.Name = "btnviewmedicine";
            this.btnviewmedicine.Size = new System.Drawing.Size(193, 58);
            this.btnviewmedicine.TabIndex = 7;
            this.btnviewmedicine.Text = "View Medicine";
            this.btnviewmedicine.UseVisualStyleBackColor = false;
            this.btnviewmedicine.Click += new System.EventHandler(this.btnviewmedicine_Click);
            // 
            // tnviewuser
            // 
            this.tnviewuser.BackColor = System.Drawing.Color.White;
            this.tnviewuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnviewuser.ForeColor = System.Drawing.Color.Red;
            this.tnviewuser.Location = new System.Drawing.Point(26, 128);
            this.tnviewuser.Name = "tnviewuser";
            this.tnviewuser.Size = new System.Drawing.Size(193, 52);
            this.tnviewuser.TabIndex = 6;
            this.tnviewuser.Text = "View User";
            this.tnviewuser.UseVisualStyleBackColor = false;
            this.tnviewuser.Click += new System.EventHandler(this.tnviewuser_Click);
            // 
            // btnaddmedicine
            // 
            this.btnaddmedicine.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnaddmedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddmedicine.ForeColor = System.Drawing.Color.Red;
            this.btnaddmedicine.Location = new System.Drawing.Point(26, 200);
            this.btnaddmedicine.Name = "btnaddmedicine";
            this.btnaddmedicine.Size = new System.Drawing.Size(193, 58);
            this.btnaddmedicine.TabIndex = 5;
            this.btnaddmedicine.Text = "Add Medicine";
            this.btnaddmedicine.UseVisualStyleBackColor = false;
            this.btnaddmedicine.Click += new System.EventHandler(this.btnaddmedicine_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.Red;
            this.btnlogout.Location = new System.Drawing.Point(26, 425);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(193, 54);
            this.btnlogout.TabIndex = 4;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnadduser
            // 
            this.btnadduser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnadduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadduser.ForeColor = System.Drawing.Color.Red;
            this.btnadduser.Location = new System.Drawing.Point(26, 47);
            this.btnadduser.Name = "btnadduser";
            this.btnadduser.Size = new System.Drawing.Size(193, 61);
            this.btnadduser.TabIndex = 3;
            this.btnadduser.Text = "Add User";
            this.btnadduser.UseVisualStyleBackColor = false;
            this.btnadduser.Click += new System.EventHandler(this.btnadduser_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(248, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(629, 511);
            this.panel2.TabIndex = 6;
            // 
            // administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(874, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "administrator";
            this.Text = "administrator";
            this.Load += new System.EventHandler(this.administrator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidepanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button tnviewuser;
        private System.Windows.Forms.Button btnaddmedicine;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnadduser;
        private System.Windows.Forms.Button btnupdatemedicine;
        private System.Windows.Forms.Button btnviewmedicine;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel2;
    }
}