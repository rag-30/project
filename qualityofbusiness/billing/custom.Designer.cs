namespace billing
{
    partial class custom
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
            this.ncb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mrp = new System.Windows.Forms.TextBox();
            this.list = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gst = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sp = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cp = new System.Windows.Forms.ComboBox();
            this.gstlabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.list)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name :";
            // 
            // ncb
            // 
            this.ncb.FormattingEnabled = true;
            this.ncb.Location = new System.Drawing.Point(126, 8);
            this.ncb.Name = "ncb";
            this.ncb.Size = new System.Drawing.Size(121, 21);
            this.ncb.TabIndex = 2;
            this.ncb.Enter += new System.EventHandler(this.ncb_Enter);
            this.ncb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ncb_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 48);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price :\r\nWithout\r\nGST";
            // 
            // mrp
            // 
            this.mrp.Location = new System.Drawing.Point(69, 109);
            this.mrp.Name = "mrp";
            this.mrp.Size = new System.Drawing.Size(60, 20);
            this.mrp.TabIndex = 5;
            this.mrp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mrp_KeyDown);
            // 
            // list
            // 
            this.list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list.Location = new System.Drawing.Point(24, 229);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(240, 150);
            this.list.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cost Price :";
            // 
            // gst
            // 
            this.gst.Location = new System.Drawing.Point(210, 109);
            this.gst.Name = "gst";
            this.gst.Size = new System.Drawing.Size(60, 20);
            this.gst.TabIndex = 11;
            this.gst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gst_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(148, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "GST % :";
            // 
            // sp
            // 
            this.sp.AutoSize = true;
            this.sp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sp.Location = new System.Drawing.Point(385, 110);
            this.sp.Name = "sp";
            this.sp.Size = new System.Drawing.Size(16, 16);
            this.sp.TabIndex = 13;
            this.sp.Text = "   ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(291, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Selling Price :";
            // 
            // cp
            // 
            this.cp.FormattingEnabled = true;
            this.cp.Location = new System.Drawing.Point(126, 54);
            this.cp.Name = "cp";
            this.cp.Size = new System.Drawing.Size(121, 21);
            this.cp.TabIndex = 14;
            this.cp.Enter += new System.EventHandler(this.cp_Enter);
            this.cp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cp_KeyDown);
            // 
            // gstlabel
            // 
            this.gstlabel.AutoSize = true;
            this.gstlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gstlabel.Location = new System.Drawing.Point(338, 173);
            this.gstlabel.Name = "gstlabel";
            this.gstlabel.Size = new System.Drawing.Size(16, 16);
            this.gstlabel.TabIndex = 16;
            this.gstlabel.Text = "   ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(291, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "GST :";
            // 
            // custom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 506);
            this.Controls.Add(this.gstlabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cp);
            this.Controls.Add(this.sp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gst);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.list);
            this.Controls.Add(this.mrp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ncb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "custom";
            this.Text = "custom";
            ((System.ComponentModel.ISupportInitialize)(this.list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ncb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mrp;
        private System.Windows.Forms.DataGridView list;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox gst;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label sp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cp;
        private System.Windows.Forms.Label gstlabel;
        private System.Windows.Forms.Label label6;
    }
}