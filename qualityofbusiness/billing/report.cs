using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace billing
{
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
            con.Open();
            string o = "select * from purstock";
            SqlDataAdapter open = new SqlDataAdapter(o, con);
            open.Fill(dt);
            string s = "select item,quant from salstock where indate between getdate()-30 and getdate()";
            SqlDataAdapter show = new SqlDataAdapter(s, con);
            show.Fill(ss);
            string l = "select item,quant from purstock where quant<=20";
            SqlDataAdapter low = new SqlDataAdapter(l,con);
            low.Fill(ll);
            curstock.DataSource = dt;
            salstock.DataSource = ss;
            lowstock.DataSource = ll;
            con.Close();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\invoice.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        DataTable dt = new DataTable();
        DataTable ss = new DataTable();
        DataTable ll = new DataTable();
        private void searchbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dt.Clear();
                string a = "select * from purstock where item like '" + searchbox.Text + "%' ";
                con.Open();
                SqlDataAdapter fil = new SqlDataAdapter(a, con);
                fil.Fill(dt);
                con.Close();
                curstock.DataSource = dt;
            }
        }

        private void cbtn_Click(object sender, EventArgs e)
        {
            searchbox.Clear();
            dt.Clear();
            con.Open();
            string c = "select * from purstock";
            SqlDataAdapter cmd = new SqlDataAdapter(c, con);
            cmd.Fill(dt);
            curstock.DataSource = dt;
            con.Close();
        }

        private void sstock_Click(object sender, EventArgs e)
        {
            ss.Clear();
            string a = "select item,quant from salstock where indate between '" + ssd.Text + "' and '"+ssd1.Text+"'";
            con.Open();
            SqlDataAdapter fild = new SqlDataAdapter(a, con);
            fild.Fill(ss);
            con.Close();
            salstock.DataSource = ss;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ss.Clear();
            string s = "select item,quant from salstock where indate between getdate()-30 and getdate()";
            con.Open();
            SqlDataAdapter show = new SqlDataAdapter(s, con);
            show.Fill(ss);
            con.Close();
            salstock.DataSource = ss;
        }
    }   
}