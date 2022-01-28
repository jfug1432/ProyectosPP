using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectosPP
{
    public partial class calculosaritmeticos : Form
    {
        public calculosaritmeticos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CLCALCULA osuma = new CLCALCULA(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
            //textBox3.Text=osuma.fsumar().ToString();
            osuma.Numero1 = double.Parse(textBox1.Text);
            osuma.Numero2 = double.Parse(textBox2.Text);
            textBox3.Text = (osuma.Numero1 + osuma.Numero2).ToString();
        }
        CLCALCULA omultiplica;
        private void button2_Click(object sender, EventArgs e)
        {
            omultiplica = new CLCALCULA(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
            // textBox3.Text = omultiplica.fmultiplicar().ToString();
            omultiplica.Numero1 = double.Parse(textBox1.Text);
            omultiplica.Numero2 = double.Parse(textBox2.Text);
            textBox3.Text = (omultiplica.Numero1 * omultiplica.Numero2).ToString();
        }
        CLCALCULA odivide;
        private void button3_Click(object sender, EventArgs e)
        {
            odivide = new CLCALCULA(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
            textBox3.Text = odivide.fdividir().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CLCALCULA oresta = new CLCALCULA(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
            textBox3.Text = oresta.frestar().ToString();
        }
    }
}
