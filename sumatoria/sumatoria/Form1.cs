using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sumatoria
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();

            double res = 0.0;

            for (int i = 1; i <= this.numericUpDown1.Value; i++) {
                res = i + res;

                if (this.checkBox1.Checked == true) {
                    this.listBox1.Items.Add("Sumando: " + i.ToString() + " suma parcial: " + res.ToString());
                }


            }
            this.listBox1.Items.Add("La suma es: " + res.ToString());

            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
