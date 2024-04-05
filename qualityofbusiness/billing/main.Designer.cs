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
            this.sidepanel = new System.Windows.Forms.Panel();
            this.ac = new System.Windows.Forms.Button();
            this.inv = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidepanel.SuspendLayout();
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
            this.sidepanel.Size = new System.Drawing.Size(141, 545);
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
            this.ac.Size = new System.Drawing.Size(141, 40);
            this.ac.TabIndex = 2;
            this.ac.Text = "Accounting";
            this.ac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ac.UseVisualStyleBackColor = false;
            this.ac.Click += new System.EventHandler(this.ac_Click);
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
            this.inv.Size = new System.Drawing.Size(141, 42);
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
            this.panel1.Location = new System.Drawing.Point(141, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 545);
            this.panel1.TabIndex = 1;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 545);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidepanel);
            this.Name = "main";
            this.Text = "main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.sidepanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidepanel;
        public System.Windows.Forms.Button inv;
        public System.Windows.Forms.Button ac;
        private System.Windows.Forms.Panel panel1;
    }
}