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
    public partial class Frm_multidimensional : Form
    {
        public Frm_multidimensional()
        {
            InitializeComponent();
        }
        //private static object pila;
        Stack<string> pila = new Stack<string>();
        int c = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            pila.Push(txtproducto.Text);
            c++;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pila.Count != 0)
            {


                DataGridViewRow row; // creamos el objeto renglón
                for (int p = 0; p < c; p++)
                {
                    row = new DataGridViewRow();
                    row.CreateCells(this.dataGridView1);
                    row.Cells[0].Value = pila.Pop();
                    this.dataGridView1.Rows.Add(row);
                }
            }
            else
                MessageBox.Show("Pila vacia");
        }
       
    }
}
