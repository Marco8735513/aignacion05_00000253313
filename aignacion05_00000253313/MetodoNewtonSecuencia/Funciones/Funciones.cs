using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aignacion05_00000253313.MetodoNewtonSecuencia.Funciones
{
    public class Funciones
    {
        public static double F(double x)
        {
            return 4 * Math.Pow(x, 3) - 6 * Math.Pow(x, 2) + 7 * x - 2.3;

        }

        public static double G(double x)
        {
            return Math.Pow(x, 2) * Math.Abs(Math.Cos(x)) - 5;
        }

        public static double Fderivada(double x)
        {
            return 12 * Math.Pow(x, 2) - 12 * x + 7;
        }
    }
}
