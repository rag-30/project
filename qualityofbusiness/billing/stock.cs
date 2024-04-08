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
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\invoice.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        DataTable pur = new DataTable();
        private void stock_Load(object sender, EventArgs e)
        {
            
        }

        private void si_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            invno.Text = si.Rows[row].Cells[0].Value.ToString();
            pid.Text = si.Rows[row].Cells[2].Value.ToString();
            sp.Text = si.Rows[row].Cells[7].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do You Want To Update The "+pid.Text+" Product To "+sp.Text+" Price","Price Update",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                string q = "update pur set sp='" + sp.Text + "' where pid='" + pid.Text + "'";
                con.Open();
                SqlCommand sc = new SqlCommand(q, con);
                sc.ExecuteNonQuery();
                pur.Clear();
                table();
                con.Close();
            }
        }

        private void table()
        {
            string a = "select * from pur";
            SqlDataAdapter da = new SqlDataAdapter(a, con);
            da.Fill(pur);
            si.DataSource = pur;
        }

    }
}
