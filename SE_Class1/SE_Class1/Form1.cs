using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_Class1
{
    public partial class Form1 : Form
    {
        string name;
        string password;
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            password = textBox4.Text;
            if (name == "")
            {
                MessageBox.Show("Error");
            }
           else if (password == "")
            {
                MessageBox.Show("Error");
            }
            else
            {
                MessageBox.Show("successfully created the account");
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            if(textBox3.Text==name && textBox2.Text == password)
            {
                MessageBox.Show("Successfully Logged in");
            }
            else
            {
                MessageBox.Show("Invalid Username or password");
            }
        }
    }
}
