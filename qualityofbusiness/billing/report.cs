using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Resources;
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
            load();
            ms();
            info.Text = DateTime.Now.ToString("MMMM");
            salstock.ColumnHeadersDefaultCellStyle.BackColor = Color.BurlyWood;
            salstock.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            salstock.EnableHeadersVisualStyles = false;
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\invoice.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        DataTable ss = new DataTable();
        private void sstock_Click(object sender, EventArgs e)
        {
            ss.Clear();
            string a = "select pd as Product,size,sum(quant) as Quantity from salstock where indate between '"+ssd.Value.ToString("yyyy-MM-dd")+"' and '"+ssd1.Value.ToString("yyyy-MM-dd")+"' group by pd,size";
            con.Open();
            SqlDataAdapter fild = new SqlDataAdapter(a, con);
            fild.Fill(ss);
            string sal = "select sum(amount) from sales where dte between '"+ssd.Value.ToString("yyyy-MM-dd")+"' and '"+ssd1.Value.ToString("yyyy-MM-dd")+"'";
            SqlCommand com = new SqlCommand(sal, con);
            SqlDataReader da = com.ExecuteReader();
            if (da.Read())
            {
                rev.Text = da[0].ToString();
            }
            con.Close();
            salstock.DataSource = ss;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ss.Clear();
            load();
            ssd.Value = DateTime.Today;
            ssd1.Value = DateTime.Today;
        }

        private void load()
        {
            con.Open();
            string q = "select sum(amount) from sales where dte between GETDATE()-7 and GETDATE()";
            SqlCommand sr = new SqlCommand(q, con);
            SqlDataReader r = sr.ExecuteReader();
            if (r.Read())
            {
                rev.Text = r[0].ToString();
            }
            con.Close();
            con.Open();
            string s = "select pd as Product,size,sum(quant) as Quantity from salstock where indate between getdate()-7 and getdate() group by pd,size";
            SqlDataAdapter show = new SqlDataAdapter(s, con);
            show.Fill(ss);
            con.Close();
            salstock.DataSource = ss;
        }

        private void ms()
        {
            string ms = "select ((select round(sum(gst),2) from sales where moth='"+DateTime.Now.ToString("MMMM")+"')-(select round(sum(gst),2) from amt where moth='"+ DateTime.Now.ToString("MMMM") +"')),sum(amount) from sales where moth='"+ DateTime.Now.ToString("MMMM") +"'";
            con.Open();
            SqlCommand s = new SqlCommand(ms, con);
            SqlDataReader msr = s.ExecuteReader();
            if (msr.Read())
            {
                mgst.Text = msr[0].ToString();
                msales.Text = msr[1].ToString();
            }
            con.Close();
        }
    }   
}