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
    public partial class custom : Form
    {
        public custom()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\invoice.mdf;Integrated Security=True;Connect Timeout=30");
        
        private void ncb_Enter(object sender, EventArgs e)
        {
            string a = "select distinct item from purstock";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(a, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "item");
            con.Close();
            ncb.DataSource = ds.Tables["item"];
            ncb.DisplayMember = "item";
            ncb.ValueMember = "item";
            ncb.DroppedDown = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = "insert into pricelist values('" + ncb.SelectedValue + "','" + cp.SelectedValue + "','" + sp.Text + "')";
            con.Open();
            SqlCommand sc = new SqlCommand(a, con);
            if (sc.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("mrp added");
            }
            string b = "select * from pricelist";
            SqlDataAdapter dr = new SqlDataAdapter(b, con);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            con.Close();
            list.DataSource = dt;
        }

        private void gst_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                float a = Convert.ToSingle(mrp.Text) * Convert.ToSingle(gst.Text) / 100;
                int b = Convert.ToInt16(a) + Convert.ToInt16(mrp.Text);
                sp.Text = b.ToString();
                gstlabel.Text = a.ToString();
            }
        }

        private void cp_Enter(object sender, EventArgs e)
        {
            string a = "select rate from pur where product ='" + ncb.SelectedValue + "'";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(a, con);
            DataSet ds = new DataSet();
             da.Fill(ds, "rate");
            con.Close();
            cp.DataSource = ds.Tables["rate"];
            cp.DisplayMember = "rate";
            cp.ValueMember = "rate";

        }

        private void mrp_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                gst.Focus();
            }
        }

        private void cp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mrp.Focus();
            }
        }

        private void ncb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cp.Focus();
                cp.DroppedDown = true;
            }
        }
    }
}
