using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadena = textBox1.Text;
            int num1 = Convert.ToInt32(cadena);
            cadena = textBox2.Text;
            int num2 = Convert.ToInt32(cadena);
            int res = num1 + num2;
            resultado.Text = res.ToString();


        }
    }
}
