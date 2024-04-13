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
using System.Windows.Forms.DataVisualization.Charting;

namespace billing
{
    public partial class stock : Form
    {
        public stock()
        {
            InitializeComponent();
            con.Open();
            table();
            con.Close();
            si.ColumnHeadersDefaultCellStyle.BackColor = Color.BurlyWood;
            si.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            si.EnableHeadersVisualStyles = false;
            curstock.ColumnHeadersDefaultCellStyle.BackColor = Color.BurlyWood;
            curstock.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            curstock.EnableHeadersVisualStyles = false;
            lowstock.ColumnHeadersDefaultCellStyle.BackColor = Color.BurlyWood;
            lowstock.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            lowstock.EnableHeadersVisualStyles = false;
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\invoice.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        DataTable pur = new DataTable();
        DataTable cur = new DataTable();
        DataTable low = new DataTable();

        private void si_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            pc.Text = si.Rows[row].Cells[0].Value.ToString();
            prd.Text = si.Rows[row].Cells[1].Value.ToString();
            sp.Text = si.Rows[row].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do You Want To Update The "+prd.Text+" Product To "+sp.Text+" Price","Price Update",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                string q = "update pur set sp='"+ sp.Text +"' where pid='"+ pc.Text +"'" +
                           "select pid as Product_ID,pd as Product,sp as Price from pur";
                con.Open();
                SqlCommand sc = new SqlCommand(q, con);
                sc.ExecuteNonQuery();
                SqlDataAdapter sqlda = new SqlDataAdapter(q, con);
                pur.Clear();
                sqlda.Fill(pur);
                si.DataSource = pur;
                con.Close();
            }
        }

        private void table()
        {
            string a = "select pid as Product_ID,pd as Product,sp as Price from pur";
            SqlDataAdapter da = new SqlDataAdapter(a, con);
            da.Fill(pur);
            string o = "select pd as Product,quant as Quantity from stock";
            SqlDataAdapter open = new SqlDataAdapter(o, con);
            open.Fill(cur);
            string l = "select pd as Product,quant as Quantity from stock where quant<=20";
            SqlDataAdapter ls = new SqlDataAdapter(l, con);
            ls.Fill(low);
            si.DataSource = pur;
            curstock.DataSource = cur;
            lowstock.DataSource = low;
        }

        private void searchbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cur.Clear();
                string a = "select pd as Product,quant as Quantity from stock where pd like '" + searchbox.Text.ToUpper() + "%'";
                con.Open();
                SqlDataAdapter fil = new SqlDataAdapter(a, con);
                fil.Fill(cur);
                con.Close();
                curstock.DataSource = cur;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            searchbox.Clear();
            cur.Clear();
            con.Open();
            string c = "select pd as Product,quant as Quantity from stock";
            SqlDataAdapter cmd = new SqlDataAdapter(c, con);
            cmd.Fill(cur);
            con.Close();
            curstock.DataSource = cur;
        }
    }
}
