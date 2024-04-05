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
            this.label6 = new System.Windows.Forms.Label();
            this.cbgst = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.qb = new System.Windows.Forms.TextBox();
            this.rate = new System.Windows.Forms.TextBox();
            this.item = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cn = new System.Windows.Forms.TextBox();
            this.inno = new System.Windows.Forms.TextBox();
            this.load = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.Label();
            this.totgst = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.purprod)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Company Name :";
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(601, 75);
            this.date.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(148, 24);
            this.date.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(544, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date :";
            // 
            // purprod
            // 
            this.purprod.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.purprod.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.purprod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purprod.Location = new System.Drawing.Point(35, 208);
            this.purprod.Name = "purprod";
            this.purprod.Size = new System.Drawing.Size(271, 201);
            this.purprod.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(236, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantity :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Item Name :";
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.Sienna;
            this.addbtn.FlatAppearance.BorderSize = 0;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addbtn.Location = new System.Drawing.Point(688, 134);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 50);
            this.addbtn.TabIndex = 7;
            this.addbtn.Text = "Add Product";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(537, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Gst :";
            // 
            // cbgst
            // 
            this.cbgst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbgst.FormattingEnabled = true;
            this.cbgst.Items.AddRange(new object[] {
            "5",
            "12",
            "18"});
            this.cbgst.Location = new System.Drawing.Point(583, 149);
            this.cbgst.Name = "cbgst";
            this.cbgst.Size = new System.Drawing.Size(56, 26);
            this.cbgst.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(383, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Rate :";
            // 
            // qb
            // 
            this.qb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qb.Location = new System.Drawing.Point(312, 149);
            this.qb.Name = "qb";
            this.qb.Size = new System.Drawing.Size(51, 24);
            this.qb.TabIndex = 11;
            // 
            // rate
            // 
            this.rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rate.Location = new System.Drawing.Point(436, 150);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(88, 24);
            this.rate.TabIndex = 12;
            // 
            // item
            // 
            this.item.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item.Location = new System.Drawing.Point(125, 150);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(100, 24);
            this.item.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(339, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Amount :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(548, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "GST :";
            // 
            // cn
            // 
            this.cn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cn.Location = new System.Drawing.Point(369, 75);
            this.cn.Name = "cn";
            this.cn.Size = new System.Drawing.Size(148, 24);
            this.cn.TabIndex = 18;
            // 
            // inno
            // 
            this.inno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inno.Location = new System.Drawing.Point(132, 75);
            this.inno.Name = "inno";
            this.inno.Size = new System.Drawing.Size(88, 24);
            this.inno.TabIndex = 19;
            // 
            // load
            // 
            this.load.BackColor = System.Drawing.Color.Sienna;
            this.load.FlatAppearance.BorderSize = 0;
            this.load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.load.Location = new System.Drawing.Point(398, 300);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(75, 50);
            this.load.TabIndex = 20;
            this.load.Text = "LOAD";
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
            this.clear.Location = new System.Drawing.Point(541, 300);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 50);
            this.clear.TabIndex = 21;
            this.clear.Text = "CLEAR";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(412, 235);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(54, 26);
            this.amount.TabIndex = 22;
            this.amount.Text = "       ";
            // 
            // totgst
            // 
            this.totgst.AutoSize = true;
            this.totgst.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totgst.Location = new System.Drawing.Point(601, 232);
            this.totgst.Name = "totgst";
            this.totgst.Size = new System.Drawing.Size(54, 26);
            this.totgst.TabIndex = 23;
            this.totgst.Text = "       ";
            // 
            // pur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 545);
            this.Controls.Add(this.totgst);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.load);
            this.Controls.Add(this.inno);
            this.Controls.Add(this.cn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.item);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.qb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbgst);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.purprod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pur";
            this.Text = "pur";
            ((System.ComponentModel.ISupportInitialize)(this.purprod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbgst;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox qb;
        private System.Windows.Forms.TextBox rate;
        private System.Windows.Forms.TextBox item;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox cn;
        private System.Windows.Forms.TextBox inno;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Label totgst;
    }
}