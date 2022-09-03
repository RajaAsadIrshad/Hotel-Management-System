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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string h_id, h_loc, h_name, t_rooms, m_name;
         static string connectdb = "Data Source=ASADIRSHAD-PC\\SQLEXPRESS01;Initial Catalog=Hotel;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectdb);
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO HOTEL VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "', '"+textBox5.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Sucessfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectdb = "Data Source=ASADIRSHAD-PC\\SQLEXPRESS01;Initial Catalog=Hotel;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectdb);
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from [Hotel]";
            cmd.ExecuteNonQuery();

            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            dataGridView1.DataSource = table;

            con.Close();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectdb = "Data Source=ASADIRSHAD-PC\\SQLEXPRESS01;Initial Catalog=Hotel;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectdb);
            con.Open();

            h_id = textBox1.Text;
            h_name = textBox2.Text;
            h_loc = textBox3.Text;
            t_rooms = textBox4.Text;
            m_name = textBox5.Text;
           

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update [Hotel] Set H_ID = '" + h_id+ "', H_NAME = '" + h_name+ "', H_LOC= '" + h_loc + "', T_ROOMS = '" + t_rooms + "', M_NAME = '"+m_name+"' WHERE H_ID = '"+h_id+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Update Sucessfully");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectdb = "Data Source=ASADIRSHAD-PC\\SQLEXPRESS01;Initial Catalog=Hotel;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectdb);
            con.Open();

            h_id = textBox1.Text;

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete From [Hotel] WHERE H_ID = '" + h_id + "' ";

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted  Sucessfully");
            
        }
    }
}
