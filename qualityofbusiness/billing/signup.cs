using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace billing
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\invoice.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        private void regbtn_Click(object sender, EventArgs e)
        {           
            Form1 lgn = new Form1();
            signup su = new signup();
            if (getpas.Text == conpas.Text)
            {
                con.Open();
                string sql = "INSERT INTO userinfo Values('" + shoptxt.Text.ToUpper() + "','" + usertxt.Text + "','" + getpas.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Sign Up Successfully","Done",MessageBoxButtons.OK);
                lgn.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Password , Please type The Password Correctly");
            }
        }
        private void signup_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
