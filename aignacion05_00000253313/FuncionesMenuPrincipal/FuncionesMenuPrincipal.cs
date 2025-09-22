using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aignacion05_00000253313.FuncionesMenuPrincipal
{
    public static class FuncionesMenuPrincipal
    {
        public static double F1(double x) => 4 * Math.Pow(x, 3) - 6 * Math.Pow(x, 2) + 7 * x - 2.3;
        public static double F2(double x) => Math.Pow(x, 2) * Math.Abs(Math.Cos(x)) - 5;
        public static double F3(double x) => x * x - 2;
        public static double F4(double x) => Math.Sin(x) - 0.5;
        public static double F5(double x) => Math.Exp(-x) - x;

        // Derivadas solo si quieres que Newton funcione
        public static double F1Derivada(double x) => 12 * x * x - 12 * x + 7;
        public static double F2Derivada(double x)
        {
            double signo = Math.Cos(x) >= 0 ? 1 : -1;
            return 2 * x * Math.Abs(Math.Cos(x)) - x * x * Math.Sin(x) * signo;
        }

        public static double F3Derivada(double x) => 2 * x;
        public static double F4Derivada(double x) => Math.Cos(x);
        public static double F5Derivada(double x) => -Math.Exp(-x) - 1;


    }
}
