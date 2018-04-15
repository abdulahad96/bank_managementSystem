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
    public partial class checkbalance : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\database\BD.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        public checkbalance(string name)
        {
            InitializeComponent();
            label5.Text = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string qur = "Select name from Table1";
            SqlDataAdapter sdq = new SqlDataAdapter(qur,con);
            DataTable dt = new DataTable();
            sdq.Fill(dt);
            Client2 c2 = new Client2(label5.Text);
            this.Hide();
            c2.Show();
        }

        private void checkbalance_Load(object sender, EventArgs e)
        {
            string query = "Select amount from Table1 where name = '"+label5.Text+"'";
            SqlDataAdapter sqd = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sqd.Fill(dt);
            label2.Text = dt.Rows[0][0].ToString();
        }

        
    }
}
