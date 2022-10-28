using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = "riolu";
            string password = "lucario";
            string t1;
            string t2;

            t1 = textBox1.Text;
            t2 = textBox2.Text;

            if (username == t1 && password == t2)
            {
                MessageBox.Show("Correcto");
            }
            else {
                MessageBox.Show("Incorrecto");
            }

            textBox1.Clear();
            textBox2.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
