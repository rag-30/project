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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.salstock = new System.Windows.Forms.DataGridView();
            this.ssd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.sstock = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ssd1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rev = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mgst = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.msales = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salstock)).BeginInit();
            this.info.SuspendLayout();
            this.SuspendLayout();
            // 
            // salstock
            // 
            this.salstock.AllowUserToAddRows = false;
            this.salstock.AllowUserToDeleteRows = false;
            this.salstock.AllowUserToResizeColumns = false;
            this.salstock.AllowUserToResizeRows = false;
            this.salstock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salstock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.salstock.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salstock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.salstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salstock.Location = new System.Drawing.Point(375, 118);
            this.salstock.Name = "salstock";
            this.salstock.ReadOnly = true;
            this.salstock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.salstock.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.salstock.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.salstock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.salstock.Size = new System.Drawing.Size(288, 282);
            this.salstock.TabIndex = 21;
            // 
            // ssd
            // 
            this.ssd.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssd.CustomFormat = "dd-MM-yyyy";
            this.ssd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ssd.Location = new System.Drawing.Point(375, 17);
            this.ssd.Name = "ssd";
            this.ssd.Size = new System.Drawing.Size(99, 26);
            this.ssd.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(324, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Date :";
            // 
            // sstock
            // 
            this.sstock.BackColor = System.Drawing.Color.Sienna;
            this.sstock.FlatAppearance.BorderSize = 0;
            this.sstock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sstock.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sstock.ForeColor = System.Drawing.Color.MistyRose;
            this.sstock.Location = new System.Drawing.Point(660, 17);
            this.sstock.Name = "sstock";
            this.sstock.Size = new System.Drawing.Size(73, 35);
            this.sstock.TabIndex = 24;
            this.sstock.Text = "Search";
            this.sstock.UseVisualStyleBackColor = false;
            this.sstock.Click += new System.EventHandler(this.sstock_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(480, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Sales Stock";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Sienna;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MistyRose;
            this.button1.Location = new System.Drawing.Point(746, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 35);
            this.button1.TabIndex = 27;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ssd1
            // 
            this.ssd1.CustomFormat = "dd-MM-yyyy";
            this.ssd1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssd1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ssd1.Location = new System.Drawing.Point(539, 17);
            this.ssd1.Name = "ssd1";
            this.ssd1.Size = new System.Drawing.Size(99, 26);
            this.ssd1.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(497, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(453, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 28);
            this.label1.TabIndex = 30;
            this.label1.Text = "Sales :";
            // 
            // rev
            // 
            this.rev.AutoSize = true;
            this.rev.BackColor = System.Drawing.Color.Wheat;
            this.rev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rev.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.rev.Location = new System.Drawing.Point(528, 433);
            this.rev.Name = "rev";
            this.rev.Size = new System.Drawing.Size(80, 28);
            this.rev.TabIndex = 31;
            this.rev.Text = "           ";
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.RosyBrown;
            this.info.Controls.Add(this.label3);
            this.info.Controls.Add(this.mgst);
            this.info.Controls.Add(this.label9);
            this.info.Controls.Add(this.msales);
            this.info.Controls.Add(this.label7);
            this.info.Location = new System.Drawing.Point(12, 12);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(283, 227);
            this.info.TabIndex = 32;
            this.info.TabStop = false;
            this.info.Text = "groupBox1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 181);
            this.label3.MinimumSize = new System.Drawing.Size(270, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "( - means excess)            (  + means payable)";
            // 
            // mgst
            // 
            this.mgst.AutoSize = true;
            this.mgst.BackColor = System.Drawing.Color.Wheat;
            this.mgst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mgst.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.mgst.Location = new System.Drawing.Point(134, 132);
            this.mgst.Name = "mgst";
            this.mgst.Size = new System.Drawing.Size(80, 28);
            this.mgst.TabIndex = 36;
            this.mgst.Text = "           ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Peru;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label9.Location = new System.Drawing.Point(73, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 27);
            this.label9.TabIndex = 35;
            this.label9.Text = "GST :";
            // 
            // msales
            // 
            this.msales.AutoSize = true;
            this.msales.BackColor = System.Drawing.Color.Wheat;
            this.msales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msales.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.msales.Location = new System.Drawing.Point(136, 50);
            this.msales.Name = "msales";
            this.msales.Size = new System.Drawing.Size(80, 28);
            this.msales.TabIndex = 34;
            this.msales.Text = "           ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Peru;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label7.Location = new System.Drawing.Point(63, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 27);
            this.label7.TabIndex = 33;
            this.label7.Text = "Sales :";
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 561);
            this.Controls.Add(this.info);
            this.Controls.Add(this.rev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ssd1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sstock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ssd);
            this.Controls.Add(this.salstock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "report";
            this.Text = "stock";
            ((System.ComponentModel.ISupportInitialize)(this.salstock)).EndInit();
            this.info.ResumeLayout(false);
            this.info.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView salstock;
        private System.Windows.Forms.DateTimePicker ssd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sstock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker ssd1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rev;
        private System.Windows.Forms.GroupBox info;
        private System.Windows.Forms.Label mgst;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label msales;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
    }
}