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
    public partial class Admin_Page : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\database\BD.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        public Admin_Page(string name)
        {
            InitializeComponent();
            label1.Text = name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "Select name from Table1";
            SqlDataAdapter sdq = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sdq.Fill(dt);
            Client2 c2 = new Client2(label1.Text);
            this.Hide();
            c2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(label1.Text);
            this.Hide();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void Admin_Page_Load(object sender, EventArgs e)
        {

        }
    }
}
