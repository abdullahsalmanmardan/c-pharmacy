namespace pharmacyproject
{
    partial class Add_Medicine_To_Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Medicine_To_Bill));
            this.btnrest = new System.Windows.Forms.Button();
            this.btnaddtobill = new System.Windows.Forms.Button();
            this.txttotalunit = new System.Windows.Forms.TextBox();
            this.txtrequnit = new System.Windows.Forms.TextBox();
            this.txtpriceperunit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtmedname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbltotalbill = new System.Windows.Forms.Label();
            this.medgirdview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.medgirdview)).BeginInit();
            this.SuspendLayout();
            // 
            // btnrest
            // 
            this.btnrest.BackColor = System.Drawing.Color.Blue;
            this.btnrest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnrest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrest.ForeColor = System.Drawing.Color.Gold;
            this.btnrest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrest.Location = new System.Drawing.Point(195, 447);
            this.btnrest.Name = "btnrest";
            this.btnrest.Size = new System.Drawing.Size(126, 40);
            this.btnrest.TabIndex = 48;
            this.btnrest.Text = "Reset";
            this.btnrest.UseVisualStyleBackColor = false;
            this.btnrest.Click += new System.EventHandler(this.btnrest_Click);
            // 
            // btnaddtobill
            // 
            this.btnaddtobill.BackColor = System.Drawing.Color.Blue;
            this.btnaddtobill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnaddtobill.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddtobill.ForeColor = System.Drawing.Color.Gold;
            this.btnaddtobill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddtobill.Location = new System.Drawing.Point(22, 447);
            this.btnaddtobill.Name = "btnaddtobill";
            this.btnaddtobill.Size = new System.Drawing.Size(133, 40);
            this.btnaddtobill.TabIndex = 47;
            this.btnaddtobill.Text = "add";
            this.btnaddtobill.UseVisualStyleBackColor = false;
            this.btnaddtobill.Click += new System.EventHandler(this.btnaddtobill_Click);
            // 
            // txttotalunit
            // 
            this.txttotalunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalunit.Location = new System.Drawing.Point(344, 125);
            this.txttotalunit.Name = "txttotalunit";
            this.txttotalunit.Size = new System.Drawing.Size(242, 26);
            this.txttotalunit.TabIndex = 46;
            this.txttotalunit.TextChanged += new System.EventHandler(this.txttotalunit_TextChanged);
            // 
            // txtrequnit
            // 
            this.txtrequnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrequnit.Location = new System.Drawing.Point(31, 181);
            this.txtrequnit.Name = "txtrequnit";
            this.txtrequnit.Size = new System.Drawing.Size(240, 26);
            this.txtrequnit.TabIndex = 43;
            // 
            // txtpriceperunit
            // 
            this.txtpriceperunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpriceperunit.Location = new System.Drawing.Point(31, 125);
            this.txtpriceperunit.Name = "txtpriceperunit";
            this.txtpriceperunit.Size = new System.Drawing.Size(240, 26);
            this.txtpriceperunit.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 24);
            this.label7.TabIndex = 41;
            this.label7.Text = "unit required";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(331, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 24);
            this.label5.TabIndex = 39;
            this.label5.Text = "total unit avaliable";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(321, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 24);
            this.label4.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 37;
            this.label1.Text = "price per unit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkBlue;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(143, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 33);
            this.label2.TabIndex = 36;
            this.label2.Text = "Add Medicine To Bill";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(587, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 40);
            this.button1.TabIndex = 35;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(177, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(395, 35);
            this.textBox1.TabIndex = 50;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.Lavender;
            this.btnsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnsearch.Image = ((System.Drawing.Image)(resources.GetObject("btnsearch.Image")));
            this.btnsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsearch.Location = new System.Drawing.Point(578, 57);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(32, 33);
            this.btnsearch.TabIndex = 49;
            this.btnsearch.UseVisualStyleBackColor = false;
            // 
            // txtmedname
            // 
            this.txtmedname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmedname.Location = new System.Drawing.Point(344, 181);
            this.txtmedname.Name = "txtmedname";
            this.txtmedname.Size = new System.Drawing.Size(242, 26);
            this.txtmedname.TabIndex = 52;
            this.txtmedname.TextChanged += new System.EventHandler(this.txtmedname_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(340, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 51;
            this.label3.Text = "med name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Gold;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(477, 447);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 40);
            this.button2.TabIndex = 53;
            this.button2.Text = "CheckOut";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 24);
            this.label6.TabIndex = 54;
            this.label6.Text = "search med";
            // 
            // lbltotalbill
            // 
            this.lbltotalbill.AutoSize = true;
            this.lbltotalbill.BackColor = System.Drawing.SystemColors.Control;
            this.lbltotalbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalbill.ForeColor = System.Drawing.Color.Lime;
            this.lbltotalbill.Location = new System.Drawing.Point(338, 449);
            this.lbltotalbill.Name = "lbltotalbill";
            this.lbltotalbill.Size = new System.Drawing.Size(106, 31);
            this.lbltotalbill.TabIndex = 55;
            this.lbltotalbill.Text = "total bill";
            // 
            // medgirdview
            // 
            this.medgirdview.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.medgirdview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medgirdview.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.medgirdview.Location = new System.Drawing.Point(22, 222);
            this.medgirdview.Name = "medgirdview";
            this.medgirdview.Size = new System.Drawing.Size(564, 194);
            this.medgirdview.TabIndex = 56;
            this.medgirdview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.medgirdview_CellContentClick);
            // 
            // Add_Medicine_To_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(629, 509);
            this.Controls.Add(this.medgirdview);
            this.Controls.Add(this.lbltotalbill);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtmedname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnrest);
            this.Controls.Add(this.btnaddtobill);
            this.Controls.Add(this.txttotalunit);
            this.Controls.Add(this.txtrequnit);
            this.Controls.Add(this.txtpriceperunit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Medicine_To_Bill";
            this.Text = "Add_Medicine_To_Bill";
            this.Load += new System.EventHandler(this.Add_Medicine_To_Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medgirdview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnrest;
        private System.Windows.Forms.Button btnaddtobill;
        private System.Windows.Forms.TextBox txttotalunit;
        private System.Windows.Forms.TextBox txtrequnit;
        private System.Windows.Forms.TextBox txtpriceperunit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtmedname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbltotalbill;
        private System.Windows.Forms.DataGridView medgirdview;
    }
}