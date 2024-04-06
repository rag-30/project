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
using Microsoft.Identity.Client;

namespace billing
{
    public partial class pur : Form
    {
        public pur()
        {
            InitializeComponent();
            i = inno.Text != null;
            c = cn.Text != null;
            it = item.Text != null;
            q = qb.Text != null;
            r = cp.Text != null;
            date.CustomFormat = "dd-MMM-yy";
            p.Columns.Add("P_ID");
            p.Columns.Add("P_Name");
            p.Columns.Add("P_Description");
            p.Columns.Add("Quant",typeof(Byte));
            p.Columns.Add("P_Price", typeof(short));
            p.Columns.Add("S_Price", typeof(short));
            purprod.DataSource = p;
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\invoice.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        uint tamt;
        float tgst;
        bool it, q, r, i, c ;
        DataTable p = new DataTable();

        private void addbtn_Click(object sender, EventArgs e)
        {
            
            
            if ((it & q & r &  i & c) == true)
            {
                p.Rows.Add(pid.Text, item.Text, pd.Text, qb.Text, cp.Text, sp.Text);
                /*con.Open();
                try
                {
                    tamt = Convert.ToUInt32(qb.Text) * Convert.ToUInt32(rate.Text);
                    tgst = (tamt) * Convert.ToSingle(cbgst.SelectedItem) / 100;
                    string a = "insert into temps values ('" + item.Text + "','" + qb.Text + "','" + rate.Text + "','" + tamt + "','" + tgst + "')";
                    SqlCommand b = new SqlCommand(a, con);
                    if (b.ExecuteNonQuery() > 0)
                    {
                        string c = "select * from temps";
                        SqlDataAdapter d = new SqlDataAdapter(c, con);
                        DataTable dt = new DataTable();
                        d.Fill(dt);
                        purprod.DataSource = dt;
                        string y = "select SUM(amount) as amount, SUM(gst) as gst from temps";
                        SqlCommand cmd = new SqlCommand(y, con);
                        SqlDataReader r = cmd.ExecuteReader();
                        if (r.Read())
                        {
                            amount.Text = r["amount"].ToString();
                            totgst.Text = r["gst"].ToString();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();*/
            }
            else
            {
                MessageBox.Show("Data Missing For Further Process", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            pid.Clear();
            item.Clear();
            pd.Clear();
            qb.Clear();
            cp.Clear();
            sp.Clear();
            pid.Focus();
        }

        private void pur_Load(object sender, EventArgs e)
        {
            purprod.ColumnHeadersDefaultCellStyle.BackColor = Color.BurlyWood;
            purprod.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            purprod.EnableHeadersVisualStyles = false;
        }

        private void load_Click(object sender, EventArgs e)
        {
            if((i & c == true) & (purprod.Rows.Count > 0))
            {
                con.Open();
                try
                {
                    string q = "insert into pur values ('" + inno.Text + "','" + cn.Text + "','" + amttxt.Text + "','" + gsttxt.Text + "','" + date.Text + "')";
                    SqlCommand sc = new SqlCommand(q, con);
                    sc.ExecuteNonQuery();
                    for (sbyte i = 0; i+1 < purprod.Rows.Count; i++)
                    {
                        string c ="exec upstock @id ='" + purprod.Rows[i].Cells[0].Value + "',@item ='" + purprod.Rows[i].Cells[1].Value + "',@pd ='" + purprod.Rows[i].Cells[2].Value + "',@quant ='" + purprod.Rows[i].Cells[3].Value + "',@cp ='" + purprod.Rows[i].Cells[4].Value+"',@sp ='" + purprod.Rows[i].Cells[5].Value+"'";
                        SqlCommand cmd = new SqlCommand(c, con);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show(purprod.Rows[i].Cells[0].Value + "inserted");
                        }
                    }
                    temps();
                    MessageBox.Show(inno.Text + "  Is Stored");

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Data Missing For Further Process", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clr();
        }

        private void clr()
        {
            inno.Clear();
            cn.Clear();
            date.Value = DateTime.Today;
            amttxt.Clear();
            gsttxt.Clear();
            p.Clear();
            purprod.DataSource = null;
        }
        private void temps()   //temps table clear function 
        {
            string a = "truncate table temps";
            SqlCommand cmd = new SqlCommand(a, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("data cleared successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            clr();
        }

        
    }
}
