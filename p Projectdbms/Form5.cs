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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        string b_id, b_date;
        static string connectdb = "Data Source=ASADIRSHAD-PC\\SQLEXPRESS01;Initial Catalog=Booking;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectdb);

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO BOOKING VALUES('" + textBox1.Text + "','" + textBox2.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Sucessfully");
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectdb = "Data Source=ASADIRSHAD-PC\\SQLEXPRESS01;Initial Catalog=Booking;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectdb);
            con.Open();

            b_id = textBox1.Text;
            b_date = textBox2.Text;



            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update [Booking] Set B_ID = '" + b_id + "', B_date = '" + b_date + "' WHERE B_ID = '" + b_id + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Update Sucessfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectdb = "Data Source=ASADIRSHAD-PC\\SQLEXPRESS01;Initial Catalog=Booking;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectdb);
            con.Open();

            b_id = textBox1.Text;

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete From [Booking] WHERE B_ID = '" + b_id + "' ";

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted  Sucessfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectdb = "Data Source=ASADIRSHAD-PC\\SQLEXPRESS01;Initial Catalog=Booking;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectdb);
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from [Booking]";
            cmd.ExecuteNonQuery();

            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            dataGridView1.DataSource = table;

            con.Close();
        }
    }
}
