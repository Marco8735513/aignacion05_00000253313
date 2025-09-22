using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaicesLogica.Funciones
{
   public class FuncionesMatematicas
    {
        public static double ErrorRelativo(double xr, double xrAnterior)
        {
            return Math.Abs((xr - xrAnterior) / xr);
        }

        //F(x)=4x3−6x2+7x−2.3
        public static double F(double x)
        {
            return 4 * Math.Pow(x, 3) - 6 * Math.Pow(x, 2) + 7 * x - 2.3;
        }

        public static double G(double x)
        {
            return Math.Pow(x, 2) * Math.Abs(Math.Cos(x)) - 5;

        }


    }
}
