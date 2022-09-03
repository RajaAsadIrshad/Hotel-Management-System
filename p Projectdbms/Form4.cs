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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string c_id, c_name, c_contact;
        static string connectdb = "Data Source=ASADIRSHAD-PC\\SQLEXPRESS01;Initial Catalog=Customer;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectdb);

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO CUSTOMER VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Sucessfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectdb = "Data Source=ASADIRSHAD-PC\\SQLEXPRESS01;Initial Catalog=Customer;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectdb);
            con.Open();

            c_id = textBox1.Text;
            c_name = textBox2.Text;
            c_contact= textBox3.Text;
           


            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update [Customer] Set C_ID = '" + c_id+ "', C_NAME = '" + c_name + "', H_CONTACT= '" + c_contact+ "' WHERE H_ID = '" + c_id + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Update Sucessfully");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectdb = "Data Source=ASADIRSHAD-PC\\SQLEXPRESS01;Initial Catalog=Customer;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectdb);
            con.Open();

            c_id = textBox1.Text;

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete From [Customer] WHERE H_ID = '" +c_id + "' ";

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted  Sucessfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectdb = "Data Source=ASADIRSHAD-PC\\SQLEXPRESS01;Initial Catalog=Customer;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectdb);
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from [Customer]";
            cmd.ExecuteNonQuery();

            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            dataGridView1.DataSource = table;

            con.Close();
          
        }
    }
}
