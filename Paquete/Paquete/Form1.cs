using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paquete
{
    public partial class Form1 : Form
    {
        string cadena = null;
        int precio = 0, precio2 = 0;
        int seleccion = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccion = comboBox1.SelectedIndex;
            switch (seleccion) {

                case 1:
                    precio = 4;
                    break;
                case 2:
                    precio = 7;
                    break;
                case 3:
                    precio = 15;
                    break;
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int resultado = precio + precio2;
            textBox1.Text = resultado.ToString();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccion = comboBox2.SelectedIndex;
            switch (seleccion)
            {

                case 1:
                    precio2 = 4;
                    break;
                case 2:
                    precio2 = 7;
                    break;
                case 3:
                    precio2 = 15;
                    break;
            }



        }
    }

    
   
}
