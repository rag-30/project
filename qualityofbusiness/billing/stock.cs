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
    public partial class stock : Form
    {
        public stock()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\invoice.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        private void stock_Load(object sender, EventArgs e)
        {
            si.ColumnHeadersDefaultCellStyle.BackColor= Color.BurlyWood;
            si.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            si.EnableHeadersVisualStyles = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(si.Rows.Count >  0)
            {
                con.Open();
                for(sbyte i =0;i+1<si.Rows.Count;i++)
                {
                    string q = "exec upstock @id ='" + si.Rows[i].Cells[0].Value + "',@item ='" + si.Rows[i].Cells[1].Value + "',@s ='" + si.Rows[i].Cells[2].Value + "',@quant ='" + si.Rows[i].Cells[3].Value + "',@cp ='" + si.Rows[i].Cells[4].Value + "',@sp ='" + si.Rows[i].Cells[5].Value + "'";
                    SqlCommand sc = new SqlCommand(q, con);
                    sc.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("stock  updated");
            }
        }
    }
}
