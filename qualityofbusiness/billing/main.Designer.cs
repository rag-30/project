namespace billing
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.sidepanel = new System.Windows.Forms.Panel();
            this.shopname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reportbtn = new System.Windows.Forms.Button();
            this.stockbtn = new System.Windows.Forms.Button();
            this.ac = new System.Windows.Forms.Button();
            this.inv = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.Tan;
            this.sidepanel.Controls.Add(this.shopname);
            this.sidepanel.Controls.Add(this.pictureBox1);
            this.sidepanel.Controls.Add(this.reportbtn);
            this.sidepanel.Controls.Add(this.stockbtn);
            this.sidepanel.Controls.Add(this.ac);
            this.sidepanel.Controls.Add(this.inv);
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidepanel.Location = new System.Drawing.Point(0, 0);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(160, 561);
            this.sidepanel.TabIndex = 0;
            // 
            // shopname
            // 
            this.shopname.AutoSize = true;
            this.shopname.BackColor = System.Drawing.Color.Khaki;
            this.shopname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopname.ForeColor = System.Drawing.Color.DarkRed;
            this.shopname.Location = new System.Drawing.Point(0, 169);
            this.shopname.MaximumSize = new System.Drawing.Size(160, 25);
            this.shopname.MinimumSize = new System.Drawing.Size(160, 30);
            this.shopname.Name = "shopname";
            this.shopname.Size = new System.Drawing.Size(160, 30);
            this.shopname.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // reportbtn
            // 
            this.reportbtn.BackColor = System.Drawing.Color.Azure;
            this.reportbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportbtn.FlatAppearance.BorderSize = 0;
            this.reportbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Linen;
            this.reportbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.reportbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportbtn.Font = new System.Drawing.Font("Segoe Print", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.reportbtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.reportbtn.Location = new System.Drawing.Point(0, 423);
            this.reportbtn.Name = "reportbtn";
            this.reportbtn.Size = new System.Drawing.Size(160, 40);
            this.reportbtn.TabIndex = 4;
            this.reportbtn.Text = "Report";
            this.reportbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportbtn.UseVisualStyleBackColor = false;
            this.reportbtn.Click += new System.EventHandler(this.reportbtn_Click);
            // 
            // stockbtn
            // 
            this.stockbtn.BackColor = System.Drawing.Color.Azure;
            this.stockbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stockbtn.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.stockbtn.FlatAppearance.BorderSize = 0;
            this.stockbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PeachPuff;
            this.stockbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.stockbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockbtn.Font = new System.Drawing.Font("Segoe Print", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.stockbtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.stockbtn.Location = new System.Drawing.Point(0, 360);
            this.stockbtn.Name = "stockbtn";
            this.stockbtn.Size = new System.Drawing.Size(160, 42);
            this.stockbtn.TabIndex = 3;
            this.stockbtn.Text = "Stock Inventory";
            this.stockbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockbtn.UseVisualStyleBackColor = false;
            this.stockbtn.Click += new System.EventHandler(this.stockbtn_Click);
            // 
            // ac
            // 
            this.ac.BackColor = System.Drawing.Color.Azure;
            this.ac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ac.FlatAppearance.BorderSize = 0;
            this.ac.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Linen;
            this.ac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.ac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ac.Font = new System.Drawing.Font("Segoe Print", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ac.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ac.Location = new System.Drawing.Point(0, 301);
            this.ac.Name = "ac";
            this.ac.Size = new System.Drawing.Size(160, 40);
            this.ac.TabIndex = 2;
            this.ac.Text = "Purchase";
            this.ac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ac.UseVisualStyleBackColor = false;
            this.ac.Click += new System.EventHandler(this.ac_Click);
            // 
            // inv
            // 
            this.inv.BackColor = System.Drawing.Color.Azure;
            this.inv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inv.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.inv.FlatAppearance.BorderSize = 0;
            this.inv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PeachPuff;
            this.inv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.inv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inv.Font = new System.Drawing.Font("Segoe Print", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.inv.ForeColor = System.Drawing.Color.SaddleBrown;
            this.inv.Location = new System.Drawing.Point(0, 244);
            this.inv.Name = "inv";
            this.inv.Size = new System.Drawing.Size(160, 42);
            this.inv.TabIndex = 1;
            this.inv.Text = "Invoice";
            this.inv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inv.UseVisualStyleBackColor = false;
            this.inv.Click += new System.EventHandler(this.inv_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(160, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 561);
            this.panel1.TabIndex = 1;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidepanel);
            this.Name = "main";
            this.Text = "main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.main_FormClosed);
            this.sidepanel.ResumeLayout(false);
            this.sidepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidepanel;
        public System.Windows.Forms.Button inv;
        public System.Windows.Forms.Button ac;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button reportbtn;
        public System.Windows.Forms.Button stockbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label shopname;
    }
}