namespace billing
{
    partial class pur
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.purprod = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.qb = new System.Windows.Forms.TextBox();
            this.cp = new System.Windows.Forms.TextBox();
            this.item = new System.Windows.Forms.TextBox();
            this.cn = new System.Windows.Forms.TextBox();
            this.inno = new System.Windows.Forms.TextBox();
            this.load = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gsttxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.amttxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.sp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.purprod)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Company Name :";
            // 
            // date
            // 
            this.date.CustomFormat = "dd-MMM-yyyy";
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(146, 131);
            this.date.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(171, 22);
            this.date.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date :";
            // 
            // purprod
            // 
            this.purprod.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.purprod.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.purprod.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.purprod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purprod.Location = new System.Drawing.Point(34, 333);
            this.purprod.Name = "purprod";
            this.purprod.Size = new System.Drawing.Size(736, 226);
            this.purprod.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantity :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Product Name :";
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.Sienna;
            this.addbtn.FlatAppearance.BorderSize = 0;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addbtn.Location = new System.Drawing.Point(364, 148);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 48);
            this.addbtn.TabIndex = 7;
            this.addbtn.Text = "Add Product";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(329, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Pur Price :";
            // 
            // qb
            // 
            this.qb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qb.Location = new System.Drawing.Point(160, 179);
            this.qb.Name = "qb";
            this.qb.Size = new System.Drawing.Size(122, 23);
            this.qb.TabIndex = 11;
            this.qb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.qb_KeyDown);
            // 
            // cp
            // 
            this.cp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cp.Location = new System.Drawing.Point(412, 35);
            this.cp.Name = "cp";
            this.cp.Size = new System.Drawing.Size(88, 22);
            this.cp.TabIndex = 12;
            this.cp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cp_KeyDown);
            // 
            // item
            // 
            this.item.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item.Location = new System.Drawing.Point(160, 84);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(122, 23);
            this.item.TabIndex = 13;
            this.item.KeyDown += new System.Windows.Forms.KeyEventHandler(this.item_KeyDown);
            // 
            // cn
            // 
            this.cn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cn.Location = new System.Drawing.Point(145, 88);
            this.cn.Name = "cn";
            this.cn.Size = new System.Drawing.Size(172, 22);
            this.cn.TabIndex = 18;
            // 
            // inno
            // 
            this.inno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inno.Location = new System.Drawing.Point(145, 33);
            this.inno.Name = "inno";
            this.inno.Size = new System.Drawing.Size(172, 22);
            this.inno.TabIndex = 19;
            // 
            // load
            // 
            this.load.BackColor = System.Drawing.Color.Sienna;
            this.load.FlatAppearance.BorderSize = 0;
            this.load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.load.Location = new System.Drawing.Point(809, 402);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(90, 50);
            this.load.TabIndex = 20;
            this.load.Text = "CONFIRM";
            this.load.UseVisualStyleBackColor = false;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Sienna;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clear.Location = new System.Drawing.Point(947, 402);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 50);
            this.clear.TabIndex = 21;
            this.clear.Text = "CLEAR";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.gsttxt);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.amttxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.inno);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cn);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(34, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 277);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase Info";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(92, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "GST :";
            // 
            // gsttxt
            // 
            this.gsttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gsttxt.Location = new System.Drawing.Point(145, 227);
            this.gsttxt.Name = "gsttxt";
            this.gsttxt.Size = new System.Drawing.Size(172, 22);
            this.gsttxt.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(72, 178);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 18);
            this.label13.TabIndex = 20;
            this.label13.Text = "Amount :";
            // 
            // amttxt
            // 
            this.amttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amttxt.Location = new System.Drawing.Point(145, 177);
            this.amttxt.Name = "amttxt";
            this.amttxt.Size = new System.Drawing.Size(172, 22);
            this.amttxt.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Tan;
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.sp);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.pid);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.pd);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.item);
            this.groupBox2.Controls.Add(this.addbtn);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.qb);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cp);
            this.groupBox2.Location = new System.Drawing.Point(460, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 232);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stock Info";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(309, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 18);
            this.label12.TabIndex = 18;
            this.label12.Text = "Selling Price :";
            // 
            // sp
            // 
            this.sp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sp.Location = new System.Drawing.Point(412, 87);
            this.sp.Name = "sp";
            this.sp.Size = new System.Drawing.Size(88, 22);
            this.sp.TabIndex = 19;
            this.sp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sp_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(70, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 18);
            this.label11.TabIndex = 16;
            this.label11.Text = "Product ID :";
            // 
            // pid
            // 
            this.pid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pid.Location = new System.Drawing.Point(160, 33);
            this.pid.Name = "pid";
            this.pid.Size = new System.Drawing.Size(122, 23);
            this.pid.TabIndex = 17;
            this.pid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pid_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Product Description :";
            // 
            // pd
            // 
            this.pd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pd.Location = new System.Drawing.Point(160, 133);
            this.pd.Name = "pd";
            this.pd.Size = new System.Drawing.Size(122, 23);
            this.pd.TabIndex = 15;
            this.pd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pd_KeyDown);
            // 
            // pur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.load);
            this.Controls.Add(this.purprod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pur";
            this.Text = "pur";
            this.Load += new System.EventHandler(this.pur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.purprod)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView purprod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox qb;
        private System.Windows.Forms.TextBox cp;
        private System.Windows.Forms.TextBox item;
        private System.Windows.Forms.TextBox cn;
        private System.Windows.Forms.TextBox inno;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox pd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox pid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox sp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox gsttxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox amttxt;
    }
}