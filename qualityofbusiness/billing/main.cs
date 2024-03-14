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
using System.Net.Http.Headers;
using System.Threading;
using System.Data.SqlTypes;

namespace billing
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LENOVO\SQLEXPRESS;Initial Catalog=invoice;Integrated Security=True;Encrypt=False");
        private void main_Load(object sender, EventArgs e)
        {
            ntxt.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string add = "insert into ino values('" + ntxt.Text + "','" + no.Text + "',"+cb1.Items+",'"+ qbox.Text +"','" + price.Text + "')";
            SqlCommand cmd = new SqlCommand(add, con);
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("data added");
            }
            else
            {
                MessageBox.Show("Please Enter Price correctly", "Invalid Value",MessageBoxButtons.OK,MessageBoxIcon.Question);
            }
            loaddata();
            con.Close();
        }
        private void loaddata()
        {
            string load = "select * from ino where mobileno =('" + no.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(load,con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            datashow.DataSource = dt;
        }

        private void Clear()
        {
            ntxt.Clear();
            no.Clear();
            qbox.Clear();
            price.Clear();
            ntxt.Focus();
        }

        private void del_Click(object sender, EventArgs e)
        {
            datashow.DataSource = null;
            Clear();
        }
    }
}
