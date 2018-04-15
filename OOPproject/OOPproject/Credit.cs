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
    public partial class Credit : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\database\BD.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        public Credit(string name)
        {
            InitializeComponent();
            label9.Text = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string quer = "Select amount from Table1 where name='"+label9.Text+"'";
            SqlDataAdapter sdq = new SqlDataAdapter(quer,con);
            DataTable dt = new DataTable();
            sdq.Fill(dt);
            Client2 c2 = new Client2(label9.Text);
            this.Hide();
            c2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            label8.Text = (double.Parse(label7.Text) + double.Parse(textBox2.Text)).ToString();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Table1 set amount='" + label8.Text + "' where name = '"+label9.Text+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Amount Updated SuccsessFully");
        }

        private void Credit_Load(object sender, EventArgs e)
        {
            string query = "Select amount from Table1 where name = '"+label9.Text+"'";
            SqlDataAdapter sqd = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sqd.Fill(dt);
            label7.Text = dt.Rows[0][0].ToString();
        }
    }
}
