using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aignacion05_00000253313.TodosLosMetodos
{
   public  class FuncionesMenuPrincipal
    {

        // Función 1 y su derivada
        public static Func<double, double> F1 = x => x * x - 2;
        public static Func<double, double> F1Derivada = x => 2 * x;

        // Función 2 y su derivada
        public static Func<double, double> F2 = x => Math.Cos(x) - x;
        public static Func<double, double> F2Derivada = x => -Math.Sin(x) - 1;

        // Función 3 y su derivada
        public static Func<double, double> F3 = x => Math.Pow(x, 3) - x - 1;
        public static Func<double, double> F3Derivada = x => 3 * x * x - 1;

        // Función 4 y su derivada
        public static Func<double, double> F4 = x => Math.Exp(x) - 3 * x;
        public static Func<double, double> F4Derivada = x => Math.Exp(x) - 3;

        // Función 5 y su derivada
        public static Func<double, double> F5 = x => x * Math.Cos(x) - 1;
        public static Func<double, double> F5Derivada = x => Math.Cos(x) - x * Math.Sin(x);

    }
}
