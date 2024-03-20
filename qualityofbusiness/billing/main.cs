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
            
            sd.Columns.Add("Invoice No", typeof(Byte));//1
            sd.Columns.Add("Customer Name");//2
            sd.Columns.Add("Phone Number");//3
            sd.Columns.Add("Product Name");//4
            sd.Columns.Add("Rate", typeof(short));//5
            sd.Columns.Add("Quantity", typeof(sbyte));//6
            sd.Columns.Add("Price", typeof(short));//7
            sd.Columns.Add("Net Price", typeof(short));//8
            sd.Columns.Add("Gst", typeof(Double));//9
            sd.Columns.Add("Total Amount", typeof(short));//10 
        }
        SqlConnection con = new SqlConnection(@"Data Source=LENOVO\SQLEXPRESS;Initial Catalog=invoice;Integrated Security=True;Encrypt=False");
        DataTable sd = new DataTable();
        short amount ,pr;
        double gst , npr;

        

        private void button1_Click(object sender, EventArgs e)
        {
            pr = Convert.ToInt16(Convert.ToInt16(price.Text) * Convert.ToInt16(qbox.Text));
            sd.Rows.Add(invshw.Text, ntxt.Text, no.Text, cb1.SelectedItem, price.Text, qbox.Text, pr);
            datashow.DataSource = sd;
            
        }

        private void clear()
        {
            ntxt.Clear();
            no.Clear();
            qbox.Clear();
            price.Clear();
            ntxt.Focus();
        }

        private void del_Click(object sender, EventArgs e)
        {
            cb1.SelectedItem = null;
            sd.Clear();
            datashow.DataSource = null;
            clear();
        }
        
        public void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            npr = 0;
            for (sbyte i = 0; i < datashow.Rows.Count; i++)
            {
                short a;
                a = Convert.ToInt16(datashow.Rows[i].Cells[6].Value);
                npr += a;
            }
            gst = (npr * 5 / 100);
            amount = 0;
            amount = Convert.ToInt16(npr + gst);
            e.Graphics.DrawString("FABRICS",new Font("arial",30,FontStyle.Bold),Brushes.Black,new Point(300,20));
            e.Graphics.DrawString("Invoice No : "+invshw.Text, new Font("calibri",18),Brushes.Black, new Point(100,80));
            e.Graphics.DrawString("Customer Name : "+ ntxt.Text, new Font("calibri", 18), Brushes.Black, new Point(450, 80));
            e.Graphics.DrawString("Phone No : " + no.Text, new Font("calibri", 18), Brushes.Black, new Point(450, 120));
            e.Graphics.DrawString("Date : " +DateTime.Now.ToString("dd-MMM-yy"), new Font("calibri", 18), Brushes.Black, new Point(100,120));
            e.Graphics.DrawLine(new Pen(Color.Brown,5), new Point(0,180), new Point(900,180));
            e.Graphics.DrawString("Product Name", new Font("arial",19,FontStyle.Bold), Brushes.Black, new Point(40,190));
            e.Graphics.DrawString("Rate",new Font("arial", 19, FontStyle.Bold), Brushes.Black, new Point(350,190));
            e.Graphics.DrawString("Quantity", new Font("arial",19, FontStyle.Bold), Brushes.Black, new Point(520,190));
            e.Graphics.DrawString("Price", new Font("arial",19, FontStyle.Bold), Brushes.Black, new Point(710,190));
            e.Graphics.DrawLine(new Pen(Color.Brown, 5), new Point(0,230), new Point(900,230));
            //sbyte d = Convert.ToSByte(datashow.Rows.Count);
            
            switch (datashow.Rows.Count)
            {
                case 1:
                    e.Graphics.DrawString(print(0,3), new Font("arial", 19, FontStyle.Bold), Brushes.Black, new Point(70, 250));
                    e.Graphics.DrawString(print(0,4), new Font("arial", 19, FontStyle.Bold), Brushes.Black, new Point(350, 250));
                    e.Graphics.DrawString(print(0,5), new Font("arial", 19, FontStyle.Bold), Brushes.Black, new Point(560, 250));
                    e.Graphics.DrawString(print(0,6), new Font("arial", 19, FontStyle.Bold), Brushes.Black, new Point(710, 250));
                    e.Graphics.DrawLine(new Pen(Color.Brown, 5), new Point(0, 300), new Point(900, 300));
                    e.Graphics.DrawString("Net Price : ", new Font("calibri", 18, FontStyle.Bold), Brushes.Black, new Point(600, 330));
                    e.Graphics.DrawString(npr.ToString(), new Font("calibri", 18, FontStyle.Regular), Brushes.Black, new Point(720, 330));
                    e.Graphics.DrawString("Gst : ", new Font("calibri", 18, FontStyle.Bold), Brushes.Black, new Point(600, 360));
                    e.Graphics.DrawString(gst.ToString(), new Font("calibri", 18, FontStyle.Regular), Brushes.Black, new Point(720, 360));
                    e.Graphics.DrawString("Amount : ", new Font("calibri", 18, FontStyle.Bold), Brushes.Black, new Point(600, 390));
                    e.Graphics.DrawString(amount.ToString(), new Font("calibri", 18, FontStyle.Regular), Brushes.Black, new Point(720, 390));
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
                    e.Graphics.DrawString("Net Price : ", new Font("calibri", 18, FontStyle.Bold), Brushes.Black, new Point(600, 400));
                    e.Graphics.DrawString(npr.ToString(), new Font("calibri", 18, FontStyle.Regular), Brushes.Black, new Point(720, 400));
                    e.Graphics.DrawString("Gst : ", new Font("calibri", 18, FontStyle.Bold), Brushes.Black, new Point(600, 450));
                    e.Graphics.DrawString(gst.ToString(), new Font("calibri", 18, FontStyle.Regular), Brushes.Black, new Point(720, 450));
                    e.Graphics.DrawString("Amount : ", new Font("calibri", 18, FontStyle.Bold), Brushes.Black, new Point(600, 500));
                    e.Graphics.DrawString(amount.ToString(), new Font("calibri", 18, FontStyle.Regular), Brushes.Black, new Point(720, 500));
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
                    e.Graphics.DrawString("Net Price : ", new Font("calibri", 18, FontStyle.Bold), Brushes.Black, new Point(600, 500));
                    e.Graphics.DrawString(npr.ToString(), new Font("calibri", 18, FontStyle.Regular), Brushes.Black, new Point(720, 500));
                    e.Graphics.DrawString("Gst : ", new Font("calibri", 18, FontStyle.Bold), Brushes.Black, new Point(600, 550));
                    e.Graphics.DrawString(gst.ToString(), new Font("calibri", 18, FontStyle.Regular), Brushes.Black, new Point(720, 550));
                    e.Graphics.DrawString("Amount : ", new Font("calibri", 18, FontStyle.Bold), Brushes.Black, new Point(600, 600));
                    e.Graphics.DrawString(amount.ToString(), new Font("calibri", 18, FontStyle.Regular), Brushes.Black, new Point(720, 600));
                    break;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            if (datashow.Rows.Count > 0)
            {
                string add;
                printPreviewDialog1.Document = printDocument1;
                con.Open();
                switch (datashow.Rows.Count)
                {
                   
                    case 1:
                         add = "insert into sales values('"+print(0,0)+"','"+print(0, 3)+"','"+ print(0, 5)+"','"+ print(0, 6)+"')";
                        SqlCommand cmd = new SqlCommand(add, con);
                        cmd.ExecuteNonQuery();
                        break;
                    case 2:
                        add = "insert into sales values('"+print(0,0)+"','"+print(0,3)+"','"+print(0,5)+"','"+print(0,6)+"') , ('"+print(0,0)+"','"+print(1,3)+"','"+print(1,5)+"','"+print(1,6)+"')";
                        SqlCommand cmd1 = new SqlCommand(add, con);
                        cmd1.ExecuteNonQuery();
                        break;
                } 
                
                /*int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("data added");
                }
                else
                {
                    MessageBox.Show("Please Enter Price correctly", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                loaddata(); */
                con.Close();
                printPreviewDialog1.ShowDialog();
            }
            else
            {
                MessageBox.Show("there is no data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void panel1_Paint(object sender, PaintEventArgs e)
        {
            string shw = "01";
            invshw.Text = shw;
        }


        public string print(SByte a,SByte b)
        {
            string x = datashow.Rows[a].Cells[b].Value.ToString();
            return x;
        }

    }
}
