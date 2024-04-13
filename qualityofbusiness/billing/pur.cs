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
            inno.Focus();
            i = inno.Text != null;
            c = cn.Text != null;
            it = item.Text != null;
            q = qb.Text != null;
            r = cp.Text != null;
            p.Columns.Add("P_ID");
            p.Columns.Add("P_Name");
            p.Columns.Add("P_Description");
            p.Columns.Add("Quant",typeof(Byte));
            p.Columns.Add("P_Price", typeof(short));
            p.Columns.Add("S_Price", typeof(short));
            purprod.DataSource = p;
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\invoice.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        bool it, q, r, i, c ;
        DataTable p = new DataTable();

        private void addbtn_Click(object sender, EventArgs e)
        {
            if ((it & q & r &  i & c) == true)
            {
                p.Rows.Add(pid.Text, item.Text.ToUpper(), pd.Text.ToUpper(), qb.Text, cp.Text, sp.Text);
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

        private void pid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                item.Focus();
            }
        }

        private void item_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                pd.Focus();
            }
            else if (e.KeyCode == Keys.Back)
            {
                pid.Focus();
            }
        }

        private void pd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                qb.Focus();
            }
            else if (e.KeyCode == Keys.Back)
            {
                item.Focus();
            }
        }

        private void qb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                cp.Focus();
            }
            else if (e.KeyCode == Keys.Back)
            {
                pd.Focus();
            }
        }

        private void cp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                sp.Focus();
            }
            else if (e.KeyCode == Keys.Back)
            {
                qb.Focus();
            }
        }

        private void sp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addbtn.PerformClick();
            }
            else if (e.KeyCode == Keys.Back)
            {
                cp.Focus();
            }
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
                    string q = "insert into amt values('"+inno.Text+"','"+cn.Text+"','"+amttxt.Text+"','"+gsttxt.Text+"','"+date.Text+"','"+date.Value.ToString("MMMM")+"')";
                    SqlCommand sc = new SqlCommand(q, con);
                    sc.ExecuteNonQuery();
                    for (sbyte i = 0; i+1 < purprod.Rows.Count; i++)
                    {
                        string c = "insert into pur values('" + inno.Text + "', '" + cn.Text + "','" + purprod.Rows[i].Cells[0].Value + "','" + purprod.Rows[i].Cells[1].Value + "','" + purprod.Rows[i].Cells[2].Value + "','" + purprod.Rows[i].Cells[3].Value + "','" + purprod.Rows[i].Cells[4].Value + "','" + purprod.Rows[i].Cells[5].Value + "','" + date.Text + "',Datename(month,'"+date.Value.ToString("yyyy-MM-dd")+"'))" +
                            "exec upstock @id ='" + purprod.Rows[i].Cells[0].Value + "',@item ='" + purprod.Rows[i].Cells[1].Value + "',@pd ='" + purprod.Rows[i].Cells[2].Value + "',@quant ='" + purprod.Rows[i].Cells[3].Value + "'";
                        SqlCommand cmd = new SqlCommand(c, con);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show(purprod.Rows[i].Cells[0].Value +" inserted");
                        }
                    }
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

        private void clear_Click(object sender, EventArgs e)
        {
            clr();
        }

        
    }
}
