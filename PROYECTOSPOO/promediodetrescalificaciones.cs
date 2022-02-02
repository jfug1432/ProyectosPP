using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectosPP.PROYECTOSPOO
{
    public partial class promediodetrescalificaciones : Form
    {
        public promediodetrescalificaciones()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // textBox4.Text = ((double.Parse(textBox1.Text) + double.Parse(textBox2.Text) + double.Parse(textBox3.Text))/3).ToString();
            CLASES.CLPROMEDIO opromedio = new CLASES.CLPROMEDIO();
          //  opromedio = new CLASES.CLPROMEDIO(double.Parse(txtcalificacion1.Text), double.Parse(txtcalificacion2.Text), double.Parse(txtcalificacion3.Text));
           
            // propiedades
            opromedio.Calificacion1 = double.Parse(txtcalificacion1.Text);
            opromedio.Calificacion2 = double.Parse(txtcalificacion2.Text);

            opromedio.Calificacion3 = double.Parse(txtcalificacion3.Text);


            txtresultado.Text = opromedio.calcularpromedio().ToString();

        }

        private void promediodetrescalificaciones_Load(object sender, EventArgs e)
        {

        }

        private void txtcalificacion1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // excluye los números
            //if ((e.KeyChar >= 32 && e.KeyChar <=47)|| (e.KeyChar>=58 && e.KeyChar<=255))
            //{
            //    MessageBox.Show("Solo números","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            //    e.Handled = true;
            //    return;
            //}

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
