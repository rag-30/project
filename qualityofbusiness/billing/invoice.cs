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
    public partial class invoice : Form
    {
        public invoice()
        {
            InitializeComponent();
            con.Open();
            Ind();
            con.Close();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\invoice.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        DataTable dt = new DataTable();
        short pr;
        float gst;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            gst = 0;
           for(sbyte i = 0; i < datashow.Rows.Count; i++)
            {
                float a;
                a = Convert.ToSingle(datashow.Rows[i].Cells[7].Value);
                gst += a;
            }
            e.Graphics.DrawString("FABRICS", new Font("arial", 30, FontStyle.Bold), Brushes.Black, new Point(300, 20));
            e.Graphics.DrawString("Invoice No : " + invtxt.Text, new Font("calibri", 18), Brushes.Black, new Point(100, 80));
            e.Graphics.DrawString("Customer Name : " + ntxt.Text, new Font("calibri", 18), Brushes.Black, new Point(450, 80));
            e.Graphics.DrawString("Phone No : " + no.Text, new Font("calibri", 18), Brushes.Black, new Point(450, 120));
            e.Graphics.DrawString("Date : " + DateTime.Now.ToString("dd-MMM-yy"), new Font("calibri", 18), Brushes.Black, new Point(100, 120));
            e.Graphics.DrawLine(new Pen(Color.Brown, 5), new Point(0, 180), new Point(900, 180));
            e.Graphics.DrawString("Product Name", new Font("arial", 19, FontStyle.Bold), Brushes.Black, new Point(40, 190));
            e.Graphics.DrawString("Rate", new Font("arial", 19, FontStyle.Bold), Brushes.Black, new Point(350, 190));
            e.Graphics.DrawString("Quantity", new Font("arial", 19, FontStyle.Bold), Brushes.Black, new Point(520, 190));
            e.Graphics.DrawString("Price", new Font("arial", 19, FontStyle.Bold), Brushes.Black, new Point(710, 190));
            e.Graphics.DrawLine(new Pen(Color.Brown, 5), new Point(0, 230), new Point(900, 230));

            switch (datashow.Rows.Count)
            {
                case 1:
                    e.Graphics.DrawString(print(0, 3), new Font("arial", 19, FontStyle.Bold), Brushes.Black, new Point(70, 250));
                    e.Graphics.DrawString(print(0, 4), new Font("arial", 19, FontStyle.Bold), Brushes.Black, new Point(350, 250));
                    e.Graphics.DrawString(print(0, 5), new Font("arial", 19, FontStyle.Bold), Brushes.Black, new Point(560, 250));
                    e.Graphics.DrawString(print(0, 6), new Font("arial", 19, FontStyle.Bold), Brushes.Black, new Point(710, 250));
                    e.Graphics.DrawLine(new Pen(Color.Brown, 5), new Point(0, 300), new Point(900, 300));
                    e.Graphics.DrawString("Gst : ", new Font("calibri", 18, FontStyle.Bold), Brushes.Black, new Point(600, 350));
                    e.Graphics.DrawString(gst.ToString(), new Font("calibri", 18, FontStyle.Regular), Brushes.Black, new Point(720, 350));
                    e.Graphics.DrawString("Amount : ", new Font("calibri", 18, FontStyle.Bold), Brushes.Black, new Point(600, 400));
                    e.Graphics.DrawString(amt.Text, new Font("calibri", 18, FontStyle.Regular), Brushes.Black, new Point(720, 400));
                    break;
                case 2:
                    e.Graphics.DrawString(print(0, 3), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(70, 250));
                    e.Graphics.DrawString(print(0, 4), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(350, 250));
                    e.Graphics.DrawString(print(0, 5), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(560, 250));
                    e.Graphics.DrawString(print(0, 6), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(710, 250));

                    e.Graphics.DrawString(print(1, 3), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(70, 300));
                    e.Graphics.DrawString(print(1, 4), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(350, 300));
                    e.Graphics.DrawString(print(1, 5), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(560, 300));
                    e.Graphics.DrawString(print(1, 6), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(710, 300));

                    e.Graphics.DrawLine(new Pen(Color.Brown, 5), new Point(0, 350), new Point(900, 350));
                    e.Graphics.DrawString("Gst : ", new Font("calibri", 18, FontStyle.Bold), Brushes.Black, new Point(600, 400));
                    e.Graphics.DrawString(gst.ToString(), new Font("calibri", 18, FontStyle.Regular), Brushes.Black, new Point(720, 400));
                    e.Graphics.DrawString("Amount : ", new Font("calibri", 18, FontStyle.Bold), Brushes.Black, new Point(600, 450));
                    e.Graphics.DrawString(amt.Text, new Font("calibri", 18, FontStyle.Regular), Brushes.Black, new Point(720, 450));
                    break;
                case 3:
                    e.Graphics.DrawString(print(0, 3), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(70, 250));
                    e.Graphics.DrawString(print(0, 4), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(350, 250));
                    e.Graphics.DrawString(print(0, 5), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(560, 250));
                    e.Graphics.DrawString(print(0, 6), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(710, 250));

                    e.Graphics.DrawString(print(1, 3), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(70, 300));
                    e.Graphics.DrawString(print(1, 4), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(350, 300));
                    e.Graphics.DrawString(print(1, 5), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(560, 300));
                    e.Graphics.DrawString(print(1, 6), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(710, 300));

                    e.Graphics.DrawString(print(2, 3), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(70, 350));
                    e.Graphics.DrawString(print(2, 4), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(350, 350));
                    e.Graphics.DrawString(print(2, 5), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(560, 350));
                    e.Graphics.DrawString(print(2, 6), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(710, 350));

                    e.Graphics.DrawLine(new Pen(Color.Brown, 5), new Point(0, 450), new Point(900, 450));
                    e.Graphics.DrawString("Gst : ", new Font("calibri", 18, FontStyle.Bold), Brushes.Black, new Point(600, 500));
                    e.Graphics.DrawString(gst.ToString(), new Font("calibri", 18, FontStyle.Regular), Brushes.Black, new Point(720, 500));
                    e.Graphics.DrawString("Amount : ", new Font("calibri", 18, FontStyle.Bold), Brushes.Black, new Point(600, 550));
                    e.Graphics.DrawString(amt.Text, new Font("calibri", 18, FontStyle.Regular), Brushes.Black, new Point(720, 550));
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            if (datashow.Rows.Count > 0)
            {
                string a;
                printPreviewDialog1.Document = printDocument1;
                a = "insert into sales(ino,cusn,quantity,price,gst) SELECT avg(ino),'"+ntxt.Text.ToUpper()+"',sum(quantity) ,sum(price),sum(gst) from tempin ";
                SqlCommand sa = new SqlCommand(a,con);
                sa.ExecuteNonQuery();
                for(sbyte i=0; i < datashow.Rows.Count; i++)
                {
                    string b = "exec item @n ='" + datashow.Rows[i].Cells[3].Value + "',@i ='" + invtxt.Text + "'" +
                               "exec minst @item ='"+datashow.Rows[i].Cells[3].Value+"', @quant ='" + datashow.Rows[i].Cells[5].Value+"',@rate ='" + datashow.Rows[i].Cells[4].Value+"',@date ='"+DateTime.Now.ToString("yyyy-MM-dd")+"'";
                    SqlCommand up = new SqlCommand(b, con);
                    up.ExecuteNonQuery();
                }
                printPreviewDialog1.ShowDialog();
            }
            else
            {
                MessageBox.Show("there is no data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string s = "truncate table tempin";
            SqlCommand cl = new SqlCommand(s, con);
            cl.ExecuteNonQuery();
            Ind();
            con.Close();
            dt.Clear();
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (datashow.Rows.Count > 0)
            {
                con.Open();
                string s = "truncate table tempin";
                SqlCommand cl = new SqlCommand(s, con);
                cl.ExecuteNonQuery();
                con.Close();
            }
            cb1.SelectedItem = null;
            dt.Clear();
            datashow.DataSource = null;
            clear();
            amt.Text = null;
        }

        private void add_Click(object sender, EventArgs e)
        {
            dt.Clear();
            gst = Convert.ToInt16(comboBox1.SelectedValue) - Convert.ToSingle(Convert.ToSingle(comboBox1.SelectedValue)/(1+(5/100)));
            double g = Math.Round(gst, 2);
            pr = Convert.ToInt16(Convert.ToInt16(comboBox1.SelectedValue) * Convert.ToInt16(qbox.Text));
            con.Open();
            string s = "insert into tempin values('" + invtxt.Text + "','" + ntxt.Text + "','" + no.Text + "','" + cb1.SelectedValue + "','" + comboBox1.SelectedValue + "','" + qbox.Text + "','" + pr + "','"+g+"')";
            SqlCommand cmd = new SqlCommand(s, con);
            if (cmd.ExecuteNonQuery() > 0)
            {
                string d = "select * from tempin";
                SqlDataAdapter sda = new SqlDataAdapter(d, con);
                sda.Fill(dt);
                datashow.DataSource = dt;
                string a = "select SUM(price) from tempin";
                SqlCommand c = new SqlCommand(a, con);
                SqlDataReader dr = c.ExecuteReader();
                if (dr.Read())
                {
                    amt.Text = dr[0].ToString();
                }
            }
            con.Close();
            cb1.SelectedItem = null;
            qbox.Clear();
            price.Clear();
        }

        private void ntxt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                no.Focus();
            }
        }

        private void no_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cb1.Focus();
                cb1.DroppedDown = true;
            }
        }

        private void cb1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                qbox.Focus();
            }
        }

        private void price_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                add.PerformClick();
            }
        }

        private void qbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                price.Focus();
            }
        }

        public string print(SByte a, SByte b)
        {
            string x = datashow.Rows[a].Cells[b].Value.ToString();
            return x;
        }
        private void clear()
        {
            ntxt.Clear();
            no.Clear();
            qbox.Clear();
            price.Clear();
            ntxt.Focus();
        }

        private void cb1_Enter(object sender, EventArgs e)
        {
            string a = "select distinct item from purstock";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(a, con);
            DataSet ds = new DataSet();
            da.Fill(ds,"item");
            con.Close();
            cb1.DataSource= ds.Tables["item"];
            cb1.DisplayMember = "item";
            cb1.ValueMember = "item";
        }

        private void Ind()
        {
            string a = "select max(ino) from sales";
            SqlCommand i = new SqlCommand(a, con);
            SqlDataReader inn = i.ExecuteReader();
            if (inn.Read())
            {
                if (inn[0] == null)
                {
                    invtxt.Text = "1";
                }
                else
                {
                    byte b = Convert.ToByte(inn[0]);
                    b += 1;
                    invtxt.Text = b.ToString();
                }
            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            string a = "select sp from pricelist where pn ='"+cb1.SelectedValue+"'";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(a, con);
            DataSet ds = new DataSet();
            da.Fill(ds,"sp");
            con.Close();
            comboBox1.DataSource = ds.Tables["sp"];
            comboBox1.DisplayMember = "sp";
            comboBox1.ValueMember = "sp";
        }

        private void comboBox2_Enter(object sender, EventArgs e)
        {
            
        }
    }
}

