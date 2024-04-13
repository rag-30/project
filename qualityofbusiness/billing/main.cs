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
            string sn = "select sn from userinfo";
            con.Open();
            SqlCommand sqlcom = new SqlCommand(sn,con);
            SqlDataReader reader = sqlcom.ExecuteReader();
            if (reader.Read())
            {
                shopname.Text = reader[0].ToString();
            }
            con.Close();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\invoice.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        private void inv_Click(object sender, EventArgs e)
        {
            chn(new invoice());
        }
        private void chn(Form form)
        {
            panel1.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.Show();
        }

        private void ac_Click(object sender, EventArgs e)
        {
            chn(new pur());
        }

        private void stockbtn_Click(object sender, EventArgs e)
        {
            chn(new stock());
        }

        private void reportbtn_Click(object sender, EventArgs e)
        {
            chn(new report());
        }
        private void main_Deactivate(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
