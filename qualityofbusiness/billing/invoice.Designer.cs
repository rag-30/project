namespace billing
{
    partial class invoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(invoice));
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.qbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.del = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.datashow = new System.Windows.Forms.DataGridView();
            this.price = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.no = new System.Windows.Forms.TextBox();
            this.ntxt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.amt = new System.Windows.Forms.Label();
            this.invtxt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.pid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.subname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.datashow)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(756, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Invoice No :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(860, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // qbox
            // 
            this.qbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qbox.Location = new System.Drawing.Point(176, 179);
            this.qbox.Name = "qbox";
            this.qbox.Size = new System.Drawing.Size(62, 21);
            this.qbox.TabIndex = 38;
            this.qbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.qbox_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Quantity :";
            // 
            // del
            // 
            this.del.BackColor = System.Drawing.Color.BurlyWood;
            this.del.FlatAppearance.BorderSize = 0;
            this.del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del.Location = new System.Drawing.Point(584, 178);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(86, 33);
            this.del.TabIndex = 35;
            this.del.Text = "Delete";
            this.del.UseVisualStyleBackColor = false;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.BurlyWood;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(430, 179);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(86, 33);
            this.add.TabIndex = 34;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // datashow
            // 
            this.datashow.AllowUserToAddRows = false;
            this.datashow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datashow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datashow.DefaultCellStyle = dataGridViewCellStyle1;
            this.datashow.Location = new System.Drawing.Point(78, 292);
            this.datashow.Name = "datashow";
            this.datashow.RowHeadersWidth = 20;
            this.datashow.Size = new System.Drawing.Size(592, 241);
            this.datashow.TabIndex = 33;
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.SystemColors.Info;
            this.price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(740, 101);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(84, 17);
            this.price.TabIndex = 32;
            this.price.KeyDown += new System.Windows.Forms.KeyEventHandler(this.price_KeyDown);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightCoral;
            this.panel5.Location = new System.Drawing.Point(740, 118);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(84, 2);
            this.panel5.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Product Name :";
            // 
            // no
            // 
            this.no.BackColor = System.Drawing.SystemColors.Info;
            this.no.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.no.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no.Location = new System.Drawing.Point(576, 26);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(187, 17);
            this.no.TabIndex = 28;
            this.no.KeyDown += new System.Windows.Forms.KeyEventHandler(this.no_KeyDown);
            // 
            // ntxt
            // 
            this.ntxt.BackColor = System.Drawing.SystemColors.Info;
            this.ntxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ntxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntxt.Location = new System.Drawing.Point(176, 26);
            this.ntxt.Name = "ntxt";
            this.ntxt.Size = new System.Drawing.Size(203, 17);
            this.ntxt.TabIndex = 27;
            this.ntxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ntxt_KeyDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCoral;
            this.panel3.Location = new System.Drawing.Point(576, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(187, 2);
            this.panel3.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(426, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mobile Number :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Location = new System.Drawing.Point(176, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 2);
            this.panel2.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Customer Name :";
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
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(757, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 18);
            this.label8.TabIndex = 42;
            this.label8.Text = "Amount :";
            // 
            // amt
            // 
            this.amt.AutoSize = true;
            this.amt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amt.Location = new System.Drawing.Point(830, 338);
            this.amt.Name = "amt";
            this.amt.Size = new System.Drawing.Size(54, 26);
            this.amt.TabIndex = 45;
            this.amt.Text = "       ";
            // 
            // invtxt
            // 
            this.invtxt.AutoSize = true;
            this.invtxt.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invtxt.Location = new System.Drawing.Point(879, 439);
            this.invtxt.Name = "invtxt";
            this.invtxt.Size = new System.Drawing.Size(54, 26);
            this.invtxt.TabIndex = 46;
            this.invtxt.Text = "       ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(662, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 52;
            this.label7.Text = "Price :";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(176, 101);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(97, 21);
            this.name.TabIndex = 53;
            // 
            // pid
            // 
            this.pid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pid.Location = new System.Drawing.Point(937, 25);
            this.pid.Name = "pid";
            this.pid.Size = new System.Drawing.Size(79, 21);
            this.pid.TabIndex = 56;
            this.pid.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(818, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 20);
            this.label9.TabIndex = 55;
            this.label9.Text = "Product Id :";
            // 
            // subname
            // 
            this.subname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subname.Location = new System.Drawing.Point(502, 102);
            this.subname.Name = "subname";
            this.subname.Size = new System.Drawing.Size(97, 21);
            this.subname.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(325, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 20);
            this.label10.TabIndex = 57;
            this.label10.Text = "Sub Product Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(863, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 59;
            this.label4.Text = "Size :";
            // 
            // size
            // 
            this.size.FormattingEnabled = true;
            this.size.Location = new System.Drawing.Point(932, 101);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(79, 21);
            this.size.TabIndex = 61;
            this.size.Enter += new System.EventHandler(this.size_Enter);
            // 
            // invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 545);
            this.Controls.Add(this.size);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.subname);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.invtxt);
            this.Controls.Add(this.amt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.qbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.del);
            this.Controls.Add(this.add);
            this.Controls.Add(this.datashow);
            this.Controls.Add(this.price);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.no);
            this.Controls.Add(this.ntxt);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "invoice";
            this.Text = "invoice";
            ((System.ComponentModel.ISupportInitialize)(this.datashow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox qbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DataGridView datashow;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox no;
        private System.Windows.Forms.TextBox ntxt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label amt;
        private System.Windows.Forms.Label invtxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox pid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox subname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox size;
    }
}