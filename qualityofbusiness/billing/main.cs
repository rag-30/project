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
        DataTable sd = new DataTable();
        short npr, amount;
        double gst;

        

    private void button1_Click(object sender, EventArgs e)
        {
            /*
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
            */
            short pr = Convert.ToInt16(Convert.ToInt16(price.Text) * Convert.ToSByte(qbox.Text));
            sd.Columns.Add("Invoice No", typeof(Byte));//1
            sd.Columns.Add("Customer Name");//2
            sd.Columns.Add("Phone Number");//3
            sd.Columns.Add("Product Name");//4
            sd.Columns.Add("Rate", typeof(short));//5
            sd.Columns.Add("Quantity",typeof(sbyte));//6
            sd.Columns.Add("Price", typeof(short));//7
            sd.Columns.Add("Net Price", typeof(short));//8
            sd.Columns.Add("Gst", typeof(Double));//9
            sd.Columns.Add("Total Amount", typeof(short));//10
            
            
            sd.Rows.Add(invshw.Text, ntxt.Text, no.Text, cb1.SelectedItem, price.Text, qbox.Text, pr);
            datashow.DataSource = sd;
            
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
        
        public void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            gst = Convert.ToDouble(npr * 5 / 100);
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
            for (sbyte i = 0; i < datashow.Rows.Count; i++)
            {
                short a;
                npr = 0;
                a = Convert.ToInt16(datashow.Rows[i].Cells[6].Value);
                npr += a;
            }
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
                    e.Graphics.DrawString(print(0, 3), new Font("arial", 19, FontStyle.Bold), Brushes.Black, new Point(70, 250));
                    e.Graphics.DrawString(print(0, 4), new Font("arial", 19, FontStyle.Bold), Brushes.Black, new Point(350, 250));
                    e.Graphics.DrawString(print(0, 5), new Font("arial", 19, FontStyle.Bold), Brushes.Black, new Point(560, 250));
                    e.Graphics.DrawString(print(0, 6), new Font("arial", 19, FontStyle.Bold), Brushes.Black, new Point(710, 250));

                    e.Graphics.DrawString(print(1, 3), new Font("arial", 19, FontStyle.Bold), Brushes.Black, new Point(70, 290));
                    e.Graphics.DrawString(print(1, 4), new Font("arial", 19, FontStyle.Bold), Brushes.Black, new Point(350, 290));
                    e.Graphics.DrawString(print(1, 5), new Font("arial", 19, FontStyle.Bold), Brushes.Black, new Point(560, 290));
                    e.Graphics.DrawString(print(1, 6), new Font("arial", 19, FontStyle.Bold), Brushes.Black, new Point(710, 290));
                    break;
            }

            
            /*e.Graphics.DrawString(print(3), new Font("arial", 19, FontStyle.Bold), Brushes.Black, new Point(70, 250));
            e.Graphics.DrawString(print(4), new Font("arial", 19, FontStyle.Bold), Brushes.Black, new Point(350, 250));
            e.Graphics.DrawString(print(5), new Font("arial", 19, FontStyle.Bold), Brushes.Black, new Point(560, 250));
            e.Graphics.DrawString(print(6), new Font("arial", 19, FontStyle.Bold), Brushes.Black, new Point(710, 250));*/
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

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

        /*public string print(sbyte no)
        {
            
            for (sbyte i = 0; i < datashow.Rows.Count)
            {
                switch (datashow.Rows.Count)
                {
                    case 1:
                        x = datashow.Rows[i].Cells[no].Value.ToString();
                        break;
                    case 2:
                        x =

                }

            }
            return x;
        }*/
    }
}
