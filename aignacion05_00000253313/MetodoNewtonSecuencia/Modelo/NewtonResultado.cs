using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aignacion05_00000253313.MetodoNewtonSecuencia.Modelo
{
    public class NewtonResultado
    {
        //Aquí guardamos el registro de los resultados de cada iteración
        public int Iteracion { get; set; }
        public double Xi { get; set; }
        public double Xr { get; set; }
        public double fxi { get; set; }
        public double Dfxi { get; set; }
        public double Ea { get; set; }
    }
}
