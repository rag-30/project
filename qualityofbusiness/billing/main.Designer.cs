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
            this.ac = new System.Windows.Forms.Button();
            this.inv = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ntxt = new System.Windows.Forms.TextBox();
            this.no = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.price = new System.Windows.Forms.TextBox();
            this.datashow = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.qbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.invshw = new System.Windows.Forms.Label();
            this.sidepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datashow)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.Thistle;
            this.sidepanel.Controls.Add(this.ac);
            this.sidepanel.Controls.Add(this.inv);
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidepanel.Location = new System.Drawing.Point(0, 0);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(164, 505);
            this.sidepanel.TabIndex = 0;
            // 
            // ac
            // 
            this.ac.BackColor = System.Drawing.Color.Linen;
            this.ac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ac.FlatAppearance.BorderSize = 0;
            this.ac.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Linen;
            this.ac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.ac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ac.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ac.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ac.Location = new System.Drawing.Point(0, 188);
            this.ac.Name = "ac";
            this.ac.Size = new System.Drawing.Size(164, 40);
            this.ac.TabIndex = 2;
            this.ac.Text = "Accounting";
            this.ac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ac.UseVisualStyleBackColor = false;
            // 
            // inv
            // 
            this.inv.BackColor = System.Drawing.Color.PeachPuff;
            this.inv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inv.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.inv.FlatAppearance.BorderSize = 0;
            this.inv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PeachPuff;
            this.inv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.inv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inv.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.inv.ForeColor = System.Drawing.Color.SaddleBrown;
            this.inv.Location = new System.Drawing.Point(0, 148);
            this.inv.Name = "inv";
            this.inv.Size = new System.Drawing.Size(164, 42);
            this.inv.TabIndex = 1;
            this.inv.Text = "Invoice";
            this.inv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inv.UseVisualStyleBackColor = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Location = new System.Drawing.Point(175, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 2);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(528, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mobile Number :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCoral;
            this.panel3.Location = new System.Drawing.Point(678, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(203, 2);
            this.panel3.TabIndex = 3;
            // 
            // ntxt
            // 
            this.ntxt.BackColor = System.Drawing.SystemColors.Info;
            this.ntxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ntxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntxt.Location = new System.Drawing.Point(175, 51);
            this.ntxt.Name = "ntxt";
            this.ntxt.Size = new System.Drawing.Size(203, 17);
            this.ntxt.TabIndex = 4;
            // 
            // no
            // 
            this.no.BackColor = System.Drawing.SystemColors.Info;
            this.no.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.no.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no.Location = new System.Drawing.Point(678, 49);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(203, 17);
            this.no.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Product Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(640, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Price :";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightCoral;
            this.panel5.Location = new System.Drawing.Point(718, 154);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(203, 2);
            this.panel5.TabIndex = 10;
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.SystemColors.Info;
            this.price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(718, 137);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(203, 17);
            this.price.TabIndex = 11;
            // 
            // datashow
            // 
            this.datashow.AllowUserToAddRows = false;
            this.datashow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datashow.Location = new System.Drawing.Point(32, 264);
            this.datashow.Name = "datashow";
            this.datashow.ReadOnly = true;
            this.datashow.Size = new System.Drawing.Size(592, 241);
            this.datashow.TabIndex = 12;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.BurlyWood;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(388, 203);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(86, 33);
            this.add.TabIndex = 13;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // del
            // 
            this.del.BackColor = System.Drawing.Color.BurlyWood;
            this.del.FlatAppearance.BorderSize = 0;
            this.del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del.Location = new System.Drawing.Point(573, 203);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(86, 33);
            this.del.TabIndex = 14;
            this.del.Text = "Delete";
            this.del.UseVisualStyleBackColor = false;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "T-SHIRT",
            "SHIRT",
            "PANT",
            "TRACK",
            "SHORTS"});
            this.cb1.Location = new System.Drawing.Point(175, 135);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(126, 21);
            this.cb1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(368, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Quantity :";
            // 
            // qbox
            // 
            this.qbox.Location = new System.Drawing.Point(468, 135);
            this.qbox.Name = "qbox";
            this.qbox.Size = new System.Drawing.Size(62, 20);
            this.qbox.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(818, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Invoice No :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.invshw);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.qbox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cb1);
            this.panel1.Controls.Add(this.del);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.datashow);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.no);
            this.panel1.Controls.Add(this.ntxt);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(164, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 505);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // invshw
            // 
            this.invshw.AutoSize = true;
            this.invshw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invshw.Location = new System.Drawing.Point(206, 200);
            this.invshw.Name = "invshw";
            this.invshw.Size = new System.Drawing.Size(0, 18);
            this.invshw.TabIndex = 22;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 505);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidepanel);
            this.Name = "main";
            this.Text = "main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.sidepanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datashow)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidepanel;
        public System.Windows.Forms.Button inv;
        public System.Windows.Forms.Button ac;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox ntxt;
        private System.Windows.Forms.TextBox no;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.DataGridView datashow;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox qbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label invshw;
    }
}