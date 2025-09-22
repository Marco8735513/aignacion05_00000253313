using aignacion05_00000253313.MetodoNewtonSecuencia.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aignacion05_00000253313.MetodoNewtonSecuencia.Service
{
    public class Resultado
    {
        public static List<NewtonResultado> Calcular(double xi, double eamax)
        {
            int iter = 0;
            int maxIter = 100; // ponemos un límite realista
            double xr, ea;

            var resultados = new List<Modelo.NewtonResultado>();

            do
            {
                double yi = Funciones.Funciones.F(xi);
                double dyi = Funciones.Funciones.Fderivada(xi);

                if (dyi == 0)
                    throw new DivideByZeroException("La derivada se hizo cero.");

                xr = xi - yi / dyi;
                ea = Math.Abs((xr - xi) / xr) * 100;


                if (iter == 0)
                {

                    resultados.Add(new Modelo.NewtonResultado
                    {
                        Iteracion = iter + 1,
                        Xi = Math.Round(xi, 4),
                        Xr = Math.Round(xr, 4),
                        fxi = Math.Round(yi, 4),
                        Dfxi = Math.Round(dyi, 4),
                        Ea = double.NaN // No hay error en la primera iteración
                    });
                }

                else
                {



                    // Guardamos la iteración en el modelo
                    resultados.Add(new Modelo.NewtonResultado
                    {
                        Iteracion = iter + 1,
                        Xi = Math.Round(xi, 4),
                        fxi = Math.Round(yi, 4),
                        Dfxi = Math.Round(dyi, 4),
                        Xr = Math.Round(xr, 4),
                        Ea = Math.Round(ea, 4)
                    });

                }

                if (ea <= eamax)
                    break; // ya encontramos la raíz con el error deseado

                xi = xr;
                iter++;
            }
            while (iter < maxIter);

            return resultados;
        }


        //Service de Secante

        public static List<SecanteResultado> Calcular2(double x1, double x2, double eamax)
        {
           

            int iter = 0;
            int maxIter = 100;
            double xr;
            double ea = double.PositiveInfinity;


            var resultados = new List<SecanteResultado>();


            do
            {

                double fx1 = Funciones.Funciones.G(x1); // función de la Secante
                double fx2 = Funciones.Funciones.G(x2);

                // Primera aproximación
                xr = x2 - ((x1 - x2) * fx2) / (fx1 - fx2);

                // Calcular error aproximado
                ea = iter == 0 ? double.NaN : Math.Abs((xr - x2) / xr) * 100;

                // Guardar resultados antes de actualizar
                Console.WriteLine($"Iteración {iter}: x1={x1}, x2={x2}, xr={xr}, fx1={fx1}, fx2={fx2}, ea={ea}");


                resultados.Add(new SecanteResultado
                {
                    Iteracion = iter + 1,
                    X1 = Math.Round(x1, 4),
                    X2 = Math.Round(x2, 4),
                    Xr = Math.Round(xr, 4),
                    fx1 = Math.Round(fx1, 4),
                    fx2 = Math.Round(fx2, 4),
                    Ea = Math.Round(ea, 4)
                });

                if (!double.IsNaN(ea) && ea <= eamax)
                    break;



                // Actualizar x1 y x2 para la siguiente iteración
                x1 = x2;
                x2 = xr;

                iter++;
            } while (iter < maxIter);

            return resultados;
        }

    }
}
