using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectosPP.CLASES
{
    class CLPROMEDIO
    {
        //CAMPOS
        private double calificacion1;
        private double calificacion2;
        private double calificacion3;

        public CLPROMEDIO(double calificacion1, double calificacion2, double calificacion3)
        {
            this.Calificacion1 = calificacion1;
            this.Calificacion2 = calificacion2;
            this.Calificacion3 = calificacion3;
        }

        public CLPROMEDIO()
        {
          
        }
        public double Calificacion1 { get => calificacion1; set => calificacion1 = value; }
        public double Calificacion2 { get => calificacion2; set => calificacion2 = value; }
        public double Calificacion3 { get => calificacion3; set => calificacion3 = value; }

        public double calcularpromedio()
        {
            return ((Calificacion1 + Calificacion2 + Calificacion3) / 3);
        }
    }

}
