using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace maquina
{
    public partial class resultado : Form
    {

        public double gastos = 0;
        public double dinero_ingresado = 0;
        public double cambio = 0;

        public resultado()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

     

        private void button5_Click(object sender, EventArgs e)
        {
            
    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double precio = 1.00;

            gastos = gastos + precio;
            textBox1.Text = Convert.ToString(gastos + "€");
        }

        private void buttonagua_Click(object sender, EventArgs e)
        {
            double precio = 3.00;

            gastos = gastos + precio;
            textBox1.Text = Convert.ToString(gastos + "€");
        }

        private void buttoncoca_Click(object sender, EventArgs e)
        {
            double precio = 7.00;

            gastos = gastos + precio;
            textBox1.Text = Convert.ToString(gastos + "€");
        }

        private void buttonenergy_Click(object sender, EventArgs e)
        {
            double precio = 10.00;

            gastos = gastos + precio;
            textBox1.Text = Convert.ToString(gastos + "€");
        }
    }
}