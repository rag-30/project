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
        SqlConnection con = new SqlConnection(@"Data Source=LENOVO\SQLEXPRESS;Initial Catalog=invoice;Integrated Security=True;Encrypt=False");
        private void regbtn_Click(object sender, EventArgs e)
        {           
            Form1 lgn = new Form1();
            if (getpas.Text == conbtn.Text)
            {
                con.Open();
                string sql = "INSERT INTO userdata(Name,Email,Password)Values('" + usertxt.Text + "','" + eml.Text + "','" + getpas.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Sign Up Successfully","Done",MessageBoxButtons.OK);
                lgn.Show();
                
            }
            else
            {
                MessageBox.Show("Incorrect Password , Please type The Password Correctly");
            }
            

        }

    }
}
