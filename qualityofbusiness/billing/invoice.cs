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
            datashow.ColumnHeadersDefaultCellStyle.BackColor = Color.BurlyWood;
            datashow.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            datashow.EnableHeadersVisualStyles = false;
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\invoice.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        DataTable dt = new DataTable();
        short pr;
        float gst;
        main m = new main();
        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            gst = 0;
           for(sbyte i = 0; i < datashow.Rows.Count; i++)
            {
                float a;
                a = Convert.ToSingle(datashow.Rows[i].Cells[7].Value);
                gst += a;
            }
            e.Graphics.DrawString(m.shopname.Text.ToString(),new Font("arial", 30, FontStyle.Bold), Brushes.Black, new Point(300, 20));
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
                    e.Graphics.DrawString(print(0, 2), new Font("arial", 19, FontStyle.Bold), Brushes.Black, new Point(70, 250));
                    e.Graphics.DrawString(print(0, 4), new Font("arial", 19, FontStyle.Bold), Brushes.Black, new Point(350, 250));
                    e.Graphics.DrawString(print(0, 5), new Font("arial", 19, FontStyle.Bold), Brushes.Black, new Point(560, 250));
                    e.Graphics.DrawString(print(0, 6), new Font("arial", 19, FontStyle.Bold), Brushes.Black, new Point(710, 250));
                    e.Graphics.DrawLine(new Pen(Color.Brown, 5), new Point(0, 300), new Point(900, 300));
                    e.Graphics.DrawString("Gst : ", new Font("calibri", 18, FontStyle.Bold), Brushes.Black, new Point(600, 350));
                    e.Graphics.DrawString(gst.ToString(), new Font("calibri", 18, FontStyle.Regular), Brushes.Black, new Point(720, 350));
                    e.Graphics.DrawString("Amount : ", new Font("calibri", 18, FontStyle.Bold), Brushes.Black, new Point(600, 400));
                    e.Graphics.DrawString(amt.Text, new Font("calibri", 18, FontStyle.Regular), Brushes.Black, new Point(720, 400));

                    e.Graphics.DrawString("Thank You For Purchasing",new Font("Microsoft Sans Serif",20,FontStyle.Underline),Brushes.BurlyWood,new Point(300,500));
                    break;
                case 2:
                    e.Graphics.DrawString(print(0, 2), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(70, 250));
                    e.Graphics.DrawString(print(0, 4), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(350, 250));
                    e.Graphics.DrawString(print(0, 5), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(560, 250));
                    e.Graphics.DrawString(print(0, 6), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(710, 250));

                    e.Graphics.DrawString(print(1, 2), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(70, 300));
                    e.Graphics.DrawString(print(1, 4), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(350, 300));
                    e.Graphics.DrawString(print(1, 5), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(560, 300));
                    e.Graphics.DrawString(print(1, 6), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(710, 300));

                    e.Graphics.DrawLine(new Pen(Color.Brown, 5), new Point(0, 350), new Point(900, 350));
                    e.Graphics.DrawString("Gst : ", new Font("calibri", 18, FontStyle.Bold), Brushes.Black, new Point(600, 400));
                    e.Graphics.DrawString(gst.ToString(), new Font("calibri", 18, FontStyle.Regular), Brushes.Black, new Point(720, 400));
                    e.Graphics.DrawString("Amount : ", new Font("calibri", 18, FontStyle.Bold), Brushes.Black, new Point(600, 450));
                    e.Graphics.DrawString(amt.Text, new Font("calibri", 18, FontStyle.Regular), Brushes.Black, new Point(720, 450));

                    e.Graphics.DrawString("Thank You For Purchasing", new Font("Microsoft Sans Serif", 20, FontStyle.Underline), Brushes.BurlyWood, new Point(300, 550));
                    break;
                case 3:
                    e.Graphics.DrawString(print(0, 2), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(70, 250));
                    e.Graphics.DrawString(print(0, 4), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(350, 250));
                    e.Graphics.DrawString(print(0, 5), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(560, 250));
                    e.Graphics.DrawString(print(0, 6), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(710, 250));

                    e.Graphics.DrawString(print(1, 2), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(70, 300));
                    e.Graphics.DrawString(print(1, 4), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(350, 300));
                    e.Graphics.DrawString(print(1, 5), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(560, 300));
                    e.Graphics.DrawString(print(1, 6), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(710, 300));

                    e.Graphics.DrawString(print(2, 2), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(70, 350));
                    e.Graphics.DrawString(print(2, 4), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(350, 350));
                    e.Graphics.DrawString(print(2, 5), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(560, 350));
                    e.Graphics.DrawString(print(2, 6), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(710, 350));

                    e.Graphics.DrawLine(new Pen(Color.Brown, 5), new Point(0, 450), new Point(900, 450));
                    e.Graphics.DrawString("Gst : ", new Font("calibri", 18, FontStyle.Bold), Brushes.Black, new Point(600, 500));
                    e.Graphics.DrawString(gst.ToString(), new Font("calibri", 18, FontStyle.Regular), Brushes.Black, new Point(720, 500));
                    e.Graphics.DrawString("Amount : ", new Font("calibri", 18, FontStyle.Bold), Brushes.Black, new Point(600, 550));
                    e.Graphics.DrawString(amt.Text, new Font("calibri", 18, FontStyle.Regular), Brushes.Black, new Point(720, 550));

                    e.Graphics.DrawString("Thank You For Purchasing", new Font("Microsoft Sans Serif", 20, FontStyle.Underline), Brushes.BurlyWood, new Point(300, 650));
                    break;
                case 4:
                    e.Graphics.DrawString(print(0, 2), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(70, 250));
                    e.Graphics.DrawString(print(0, 4), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(350, 250));
                    e.Graphics.DrawString(print(0, 5), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(560, 250));
                    e.Graphics.DrawString(print(0, 6), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(710, 250));

                    e.Graphics.DrawString(print(1, 2), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(70, 300));
                    e.Graphics.DrawString(print(1, 4), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(350, 300));
                    e.Graphics.DrawString(print(1, 5), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(560, 300));
                    e.Graphics.DrawString(print(1, 6), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(710, 300));

                    e.Graphics.DrawString(print(2, 2), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(70, 350));
                    e.Graphics.DrawString(print(2, 4), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(350, 350));
                    e.Graphics.DrawString(print(2, 5), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(560, 350));
                    e.Graphics.DrawString(print(2, 6), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(710, 350));

                    e.Graphics.DrawString(print(3, 2), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(70, 400));
                    e.Graphics.DrawString(print(3, 4), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(350, 400));
                    e.Graphics.DrawString(print(3, 5), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(560, 400));
                    e.Graphics.DrawString(print(3, 6), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(710, 400));

                    e.Graphics.DrawLine(new Pen(Color.Brown, 5), new Point(0, 450), new Point(900, 450));
                    e.Graphics.DrawString("Gst : ", new Font("calibri", 18, FontStyle.Bold), Brushes.Black, new Point(600, 500));
                    e.Graphics.DrawString(gst.ToString(), new Font("calibri", 18, FontStyle.Regular), Brushes.Black, new Point(720, 500));
                    e.Graphics.DrawString("Amount : ", new Font("calibri", 18, FontStyle.Bold), Brushes.Black, new Point(600, 550));
                    e.Graphics.DrawString(amt.Text, new Font("calibri", 18, FontStyle.Regular), Brushes.Black, new Point(720, 550));

                    e.Graphics.DrawString("Thank You For Purchasing", new Font("Microsoft Sans Serif", 20, FontStyle.Underline), Brushes.BurlyWood, new Point(300, 650));
                    break;
                case 5:
                    e.Graphics.DrawString(print(0, 2), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(70, 250));
                    e.Graphics.DrawString(print(0, 4), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(350, 250));
                    e.Graphics.DrawString(print(0, 5), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(560, 250));
                    e.Graphics.DrawString(print(0, 6), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(710, 250));

                    e.Graphics.DrawString(print(1, 2), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(70, 300));
                    e.Graphics.DrawString(print(1, 4), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(350, 300));
                    e.Graphics.DrawString(print(1, 5), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(560, 300));
                    e.Graphics.DrawString(print(1, 6), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(710, 300));

                    e.Graphics.DrawString(print(2, 2), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(70, 350));
                    e.Graphics.DrawString(print(2, 4), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(350, 350));
                    e.Graphics.DrawString(print(2, 5), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(560, 350));
                    e.Graphics.DrawString(print(2, 6), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(710, 350));

                    e.Graphics.DrawString(print(3, 2), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(70, 400));
                    e.Graphics.DrawString(print(3, 4), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(350, 400));
                    e.Graphics.DrawString(print(3, 5), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(560, 400));
                    e.Graphics.DrawString(print(3, 6), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(710, 400));

                    e.Graphics.DrawString(print(4, 2), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(70, 450));
                    e.Graphics.DrawString(print(4, 4), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(350, 450));
                    e.Graphics.DrawString(print(4, 5), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(560, 450));
                    e.Graphics.DrawString(print(4, 6), new Font("arial", 19, FontStyle.Regular), Brushes.Black, new Point(710, 450));

                    e.Graphics.DrawLine(new Pen(Color.Brown, 5), new Point(0, 500), new Point(900, 500));
                    e.Graphics.DrawString("Gst : ", new Font("calibri", 18, FontStyle.Bold), Brushes.Black, new Point(600, 550));
                    e.Graphics.DrawString(gst.ToString(), new Font("calibri", 18, FontStyle.Regular), Brushes.Black, new Point(720, 550));
                    e.Graphics.DrawString("Amount : ", new Font("calibri", 18, FontStyle.Bold), Brushes.Black, new Point(600, 600));
                    e.Graphics.DrawString(amt.Text, new Font("calibri", 18, FontStyle.Regular), Brushes.Black, new Point(720, 600));

                    e.Graphics.DrawString("Thank You For Purchasing", new Font("Microsoft Sans Serif", 20, FontStyle.Underline), Brushes.BurlyWood, new Point(300,700));
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
                a = "insert into sales SELECT '"+invtxt.Text+"','"+ntxt.Text.ToUpper()+"','"+no.Text+"',sum(price),sum(gst),'"+DateTime.Today.ToString("yyyy-MM-dd")+"','"+DateTime.Now.ToString("MMMM")+"' from tempin ";
                SqlCommand sa = new SqlCommand(a,con);
                sa.ExecuteNonQuery();
                for(sbyte i=0; i < datashow.Rows.Count; i++)
                {
                    string b ="exec minst @id ='"+datashow.Rows[i].Cells[0].Value+"',@n ='" + datashow.Rows[i].Cells[1].Value+"',@pd ='" + datashow.Rows[i].Cells[2].Value+"',@s ='" + datashow.Rows[i].Cells[3].Value+"', @quant ='" + datashow.Rows[i].Cells[5].Value+"',@rate ='" + datashow.Rows[i].Cells[4].Value+"',@date ='"+DateTime.Now.ToString("yyyy-MM-dd")+"'";
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
            dt.Clear();
            datashow.DataSource = null;
            clear();
            amt.Text = null;
        }

        private void add_Click(object sender, EventArgs e)
        {
            dt.Clear();
            pr = Convert.ToInt16(Convert.ToInt16(price.Text) * Convert.ToInt16(qbox.Text));
            gst = Convert.ToSingle(pr) - (Convert.ToSingle(pr) / (1 + (Convert.ToSingle(5) / 100)));
            double g = Math.Round(gst, 2);
            con.Open();
            string s = "insert into tempin values('" + pid.Text + "','" + name.Text + "','" + subname.Text + "','"+size.Text+"','" +price.Text+ "','" + qbox.Text + "','" + pr + "','"+g+"')";
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
            qbox.Clear();
            price.Clear();
            name.Clear();
            subname.Clear();
            pid.Clear();
            size.SelectedText = null;
            pid.Focus();
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
                pid.Focus();
            }
        }

        private void qbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                add.PerformClick();
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
        private void Ind()
        {
            string a = "select max(ino) from sales";
            SqlCommand i = new SqlCommand(a, con);
            SqlDataReader inn = i.ExecuteReader();
            if (inn.Read())
            {
                if (inn[0] == DBNull.Value)
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
        private void textBox3_Leave(object sender, EventArgs e)
        {
            string a = "select prod,pd,sp from pur where pid='"+pid.Text+"'";
            con.Open();
            SqlCommand id = new SqlCommand(a, con);
            SqlDataReader dr = id.ExecuteReader();
            if (dr.Read())
            {
                name.Text = dr[0].ToString();
                subname.Text = dr[1].ToString();
                price.Text = dr[2].ToString();
            }
            con.Close();
        }

        private void size_Enter(object sender, EventArgs e)
        {
            if(name.Text=="SHIRT" || name.Text == "T-SHIRT")
            {
                size.Items.Add("38");
                size.Items.Add("40");
                size.Items.Add("42");
                size.Items.Add("44");
                size.Items.Add("46");
            }
            else
            {
                size.Items.Add("30");
                size.Items.Add("32");
                size.Items.Add("34");
                size.Items.Add("36");
                size.Items.Add("38");
                size.Items.Add("40");
                size.Items.Add("42");
                size.Items.Add("44");
            }
        }

        private void pid_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                size.Focus();
            }
        }

        private void size_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                qbox.Focus();
            }
        }

        private void size_Leave(object sender, EventArgs e)
        {
            size.Items.Clear();
        }
    }
}

