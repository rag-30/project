namespace billing
{
    partial class report
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
            this.curstock = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.cbtn = new System.Windows.Forms.Button();
            this.salstock = new System.Windows.Forms.DataGridView();
            this.ssd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.sstock = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ssd1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lowstock = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.curstock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salstock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowstock)).BeginInit();
            this.SuspendLayout();
            // 
            // curstock
            // 
            this.curstock.AllowUserToAddRows = false;
            this.curstock.AllowUserToDeleteRows = false;
            this.curstock.AllowUserToResizeColumns = false;
            this.curstock.AllowUserToResizeRows = false;
            this.curstock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.curstock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.curstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.curstock.Location = new System.Drawing.Point(41, 118);
            this.curstock.Name = "curstock";
            this.curstock.ReadOnly = true;
            this.curstock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.curstock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.curstock.Size = new System.Drawing.Size(177, 211);
            this.curstock.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Filter :";
            // 
            // searchbox
            // 
            this.searchbox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox.Location = new System.Drawing.Point(66, 23);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(100, 25);
            this.searchbox.TabIndex = 19;
            this.searchbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchbox_KeyDown);
            // 
            // cbtn
            // 
            this.cbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtn.Location = new System.Drawing.Point(183, 22);
            this.cbtn.Name = "cbtn";
            this.cbtn.Size = new System.Drawing.Size(60, 26);
            this.cbtn.TabIndex = 20;
            this.cbtn.Text = "Clear";
            this.cbtn.UseVisualStyleBackColor = true;
            this.cbtn.Click += new System.EventHandler(this.cbtn_Click);
            // 
            // salstock
            // 
            this.salstock.AllowUserToAddRows = false;
            this.salstock.AllowUserToDeleteRows = false;
            this.salstock.AllowUserToResizeColumns = false;
            this.salstock.AllowUserToResizeRows = false;
            this.salstock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salstock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salstock.Location = new System.Drawing.Point(361, 162);
            this.salstock.Name = "salstock";
            this.salstock.ReadOnly = true;
            this.salstock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.salstock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.salstock.Size = new System.Drawing.Size(263, 211);
            this.salstock.TabIndex = 21;
            // 
            // ssd
            // 
            this.ssd.CustomFormat = "dd-MMM-yyyy";
            this.ssd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ssd.Location = new System.Drawing.Point(382, 23);
            this.ssd.Name = "ssd";
            this.ssd.Size = new System.Drawing.Size(99, 23);
            this.ssd.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Date :";
            // 
            // sstock
            // 
            this.sstock.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sstock.Location = new System.Drawing.Point(382, 76);
            this.sstock.Name = "sstock";
            this.sstock.Size = new System.Drawing.Size(60, 26);
            this.sstock.TabIndex = 24;
            this.sstock.Text = "Search";
            this.sstock.UseVisualStyleBackColor = true;
            this.sstock.Click += new System.EventHandler(this.sstock_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Current Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(442, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Sales Stock";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(468, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 26);
            this.button1.TabIndex = 27;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ssd1
            // 
            this.ssd1.CustomFormat = "dd-MMM-yyyy";
            this.ssd1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssd1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ssd1.Location = new System.Drawing.Point(546, 23);
            this.ssd1.Name = "ssd1";
            this.ssd1.Size = new System.Drawing.Size(99, 23);
            this.ssd1.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(504, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "To";
            // 
            // lowstock
            // 
            this.lowstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lowstock.Location = new System.Drawing.Point(804, 76);
            this.lowstock.Name = "lowstock";
            this.lowstock.Size = new System.Drawing.Size(180, 150);
            this.lowstock.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(852, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Sales Stock";
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 545);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lowstock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ssd1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sstock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ssd);
            this.Controls.Add(this.salstock);
            this.Controls.Add(this.cbtn);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.curstock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "report";
            this.Text = "stock";
            ((System.ComponentModel.ISupportInitialize)(this.curstock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salstock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowstock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView curstock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Button cbtn;
        private System.Windows.Forms.DataGridView salstock;
        private System.Windows.Forms.DateTimePicker ssd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sstock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker ssd1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView lowstock;
        private System.Windows.Forms.Label label6;
    }
}