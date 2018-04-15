using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OOPproject
{
    
    public partial class Client2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\database\BD.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");    
        public Client2(string name)
        {
            InitializeComponent();
            string query = "Select role from Table1 where name='"+name+"'";
            SqlDataAdapter sqd = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sqd.Fill(dt);
            label2.Text = name;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkbalance cb = new checkbalance(label2.Text);
            this.Hide();
            cb.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            debit db = new debit(label2.Text);
            this.Hide();
            db.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Credit cr = new Credit(label2.Text);
            this.Hide();
            cr.Show();
        }

        private void Client2_Load(object sender, EventArgs e)
        {

        }
    }
}
