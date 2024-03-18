using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.NetworkInformation;

namespace billing
{
    public partial class Form1 : Form
    {
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        public TextBox usertxt;
        private Label label1;
        private TextBox pwtxt;
        private Button logbtn;
        private Button signbtn;
        private Label Usern;

        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LENOVO\SQLEXPRESS;Initial Catalog=invoice;Integrated Security=True;Encrypt=False");
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pwtxt = new System.Windows.Forms.TextBox();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Usern = new System.Windows.Forms.Label();
            this.logbtn = new System.Windows.Forms.Button();
            this.signbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 370);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pwtxt);
            this.groupBox1.Controls.Add(this.usertxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Usern);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(344, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 170);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LoginForm";
            // 
            // pwtxt
            // 
            this.pwtxt.BackColor = System.Drawing.SystemColors.Info;
            this.pwtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pwtxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwtxt.Location = new System.Drawing.Point(109, 100);
            this.pwtxt.Name = "pwtxt";
            this.pwtxt.Size = new System.Drawing.Size(197, 27);
            this.pwtxt.TabIndex = 3;
            this.pwtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usertxt
            // 
            this.usertxt.BackColor = System.Drawing.SystemColors.Info;
            this.usertxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usertxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertxt.Location = new System.Drawing.Point(109, 56);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(197, 27);
            this.usertxt.TabIndex = 2;
            this.usertxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password  :";
            // 
            // Usern
            // 
            this.Usern.AutoSize = true;
            this.Usern.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usern.Location = new System.Drawing.Point(6, 51);
            this.Usern.Name = "Usern";
            this.Usern.Size = new System.Drawing.Size(97, 23);
            this.Usern.TabIndex = 0;
            this.Usern.Text = "Username  :";
            // 
            // logbtn
            // 
            this.logbtn.BackColor = System.Drawing.Color.Peru;
            this.logbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logbtn.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logbtn.Location = new System.Drawing.Point(453, 281);
            this.logbtn.Name = "logbtn";
            this.logbtn.Size = new System.Drawing.Size(91, 39);
            this.logbtn.TabIndex = 2;
            this.logbtn.Text = "Login";
            this.logbtn.UseVisualStyleBackColor = false;
            this.logbtn.Click += new System.EventHandler(this.logbtn_Click);
            // 
            // signbtn
            // 
            this.signbtn.BackColor = System.Drawing.Color.Peru;
            this.signbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signbtn.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signbtn.Location = new System.Drawing.Point(558, 281);
            this.signbtn.Name = "signbtn";
            this.signbtn.Size = new System.Drawing.Size(92, 38);
            this.signbtn.TabIndex = 3;
            this.signbtn.Text = "Signup";
            this.signbtn.UseVisualStyleBackColor = false;
            this.signbtn.Click += new System.EventHandler(this.signbtn_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(748, 370);
            this.Controls.Add(this.signbtn);
            this.Controls.Add(this.logbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.TransparencyKey = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void signbtn_Click(object sender, EventArgs e)
        {
            signup sgn = new signup();
            sgn.Show();
            this.Hide();
        }

        private void logbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Select * From userinfo Where username='" + usertxt.Text + "' AND psw='" + pwtxt.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dta = new DataTable();
                sda.Fill(dta);
                if (dta.Rows.Count > 0)
                {
                    main mn = new main();
                    mn.Show();
                    this.Hide();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("This Account Is Not Created , Plese Click the Signup Button to Create Account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    usertxt.Clear();
                    pwtxt.Clear();
                    usertxt.Focus();
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
        } 
    }
}
