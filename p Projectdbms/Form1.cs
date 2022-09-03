using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace p_Projectdbms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text != "Raja Asad Irshad")
            {
                errorProvider1.SetError(textBox1, "Plz Provide Valid username");
            }
                else if (textBox2.Text == "" || textBox2.Text != "asadajk")
            {
                errorProvider1.SetError(textBox2, "Plz Provide Valid username");
            }
            else 
            {
                errorProvider1.Clear();
                    errorProvider2.Clear();
                    Form2 f2 = new Form2();
                    f2.Show();
               
            }
            
           
            
            
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }
    }
}
