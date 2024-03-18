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

        public DataTable storedata()
        {
            short pr = Convert.ToInt16(Convert.ToInt16(price.Text) * Convert.ToSByte(qbox.Text));
            //short gst = Convert.ToInt16(Convert.ToInt16(price.Text) * 5/100);
            DataTable sd = new DataTable();
            sd.Columns.Add("Invoice No", typeof(Byte));//1
            sd.Columns.Add("Customer Name");//2
            sd.Columns.Add("Phone Number");//3
            sd.Columns.Add("Product Name");//4
            sd.Columns.Add("Quantity", typeof(sbyte));//5
            sd.Columns.Add("Rate", typeof(short));//6
            sd.Columns.Add("Price", typeof(short));//7
            sd.Columns.Add("Net Price", typeof(short));//8
            sd.Columns.Add("Gst", typeof(float));//9
            sd.Columns.Add("Total Amount", typeof(short));//10
            sd.Rows.Add(invshw.Text, ntxt.Text, no.Text, cb1.SelectedItem, qbox.Text, price.Text, pr);
            return sd;
        }

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
            datashow.DataSource = storedata();
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
            e.Graphics.DrawString("FABRICS",new Font("arial",30,FontStyle.Bold),Brushes.Black,new Point(300,20));
            e.Graphics.DrawString("Invoice No : "+invshw.Text, new Font("calibri",18),Brushes.Black, new Point(100,80));
            e.Graphics.DrawString("Customer Name : "+ ntxt.Text, new Font("calibri", 18), Brushes.Black, new Point(450, 80));
            e.Graphics.DrawString("Phone No : " + no.Text, new Font("calibri", 18), Brushes.Black, new Point(450, 120));
            e.Graphics.DrawString("Date : " +DateTime.Now.ToString("dd-MMM-yy"), new Font("calibri", 18), Brushes.Black, new Point(100,120));
            e.Graphics.DrawLine(new Pen(Color.Brown,5), new Point(0,180), new Point(900,180));
            e.Graphics.DrawString("Product Name", new Font("arial",19,FontStyle.Bold), Brushes.Black, new Point(40,190));
            e.Graphics.DrawString("Rate",new Font("arial", 19, FontStyle.Bold), Brushes.Black, new Point(380,190));
            e.Graphics.DrawString("Quantity", new Font("arial",19, FontStyle.Bold), Brushes.Black, new Point(550,190));
            e.Graphics.DrawString("Price", new Font("arial",19, FontStyle.Bold), Brushes.Black, new Point(700,190));
            e.Graphics.DrawLine(new Pen(Color.Brown, 5), new Point(0,230), new Point(900,230)); 
            
            
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
    }
}
