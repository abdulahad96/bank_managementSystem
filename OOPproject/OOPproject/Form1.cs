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
    public partial class Form1 : Form
    {
        SqlConnection sqcon = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\database\BD.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "Select role from Table1 where name='" + textBox1.Text + "' and password='" + textBox2.Text + "'";
            
           
            SqlDataAdapter sda = new SqlDataAdapter(query, sqcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
            //    Admin_Page ad = new Admin_Page(textBox1.Text);
              //  ad.Show();
                if (dt.Rows[0][0].ToString() == "admin")
                {
                    Admin_Page ad = new Admin_Page(textBox1.Text);
                    this.Hide();
                    ad.Show();
                }
                else
                {

                    Client2 nw = new Client2(textBox1.Text);
                    this.Hide();
                    nw.Show();
                }
            }
            else
            {
                MessageBox.Show("invalid character");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
