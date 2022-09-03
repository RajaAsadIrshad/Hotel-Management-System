using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace p_Projectdbms
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        string p_id, p_date,p_amt;
        static string connectdb = "Data Source=ASADIRSHAD-PC\\SQLEXPRESS01;Initial Catalog=Payment;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectdb);
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO PAYMENT VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Sucessfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectdb = "Data Source=ASADIRSHAD-PC\\SQLEXPRESS01;Initial Catalog=Payment;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectdb);
            con.Open();

            p_id = textBox1.Text;
            p_date = textBox2.Text;
            p_amt = textBox3.Text;



            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update [Payment] Set B_ID = '" + p_id + "', B_date = '" + p_date + "' WHERE B_ID = '" + p_amt + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Update Sucessfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectdb = "Data Source=ASADIRSHAD-PC\\SQLEXPRESS01;Initial Catalog=Payment;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectdb);
            con.Open();

            p_id = textBox1.Text;
            p_date = textBox2.Text;
            p_amt = textBox3.Text;

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete From [Payment] WHERE P_ID = '" + p_id + "' ";

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted  Sucessfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectdb = "Data Source=ASADIRSHAD-PC\\SQLEXPRESS01;Initial Catalog=Payment;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectdb);
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from [Payment]";
            cmd.ExecuteNonQuery();

            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            dataGridView1.DataSource = table;

            con.Close();
        }
    }
}
