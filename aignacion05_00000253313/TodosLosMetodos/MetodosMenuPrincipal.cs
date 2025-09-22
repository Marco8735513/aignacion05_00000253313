using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aignacion05_00000253313.TodosLosMetodos
{
    public class MetodosMenuPrincipal
    {
        // ----- Bisección -----
        public static ModeloMostrarTodos Biseccion(double xi, double xf, double tol, Func<double, double> f)
        {
            double xr = xi;
            double ea = double.MaxValue;
            int iter = 0;

            while (ea > tol)
            {
                double xrPrev = xr;
                xr = (xi + xf) / 2.0;
                double fxi = f(xi);
                double fxr = f(xr);

                if (fxi * fxr < 0)
                    xf = xr;
                else
                    xi = xr;

                ea = Math.Abs(xr - xrPrev);
                iter++;
            }

            return new ModeloMostrarTodos
            {
                Metodo = "Bisección",
                Iteraciones = iter,
                Raiz = xr,
                Yraiz = f(xr),
                ErrorAprox = ea
            };
        }

        // ----- Regla Falsa -----
        public static ModeloMostrarTodos  ReglaFalsa(double xi, double xf, double tol, Func<double, double> f)
        {
            double xr = xi;
            double ea = double.MaxValue;
            int iter = 0;

            while (ea > tol)
            {
                double fxi = f(xi);
                double fxf = f(xf);

                double xrPrev = xr;
                xr = (xi * fxf - xf * fxi) / (fxf - fxi);
                double fxr = f(xr);

                if (fxi * fxr < 0)
                    xf = xr;
                else
                    xi = xr;

                ea = Math.Abs(xr - xrPrev);
                iter++;
            }

            return new ModeloMostrarTodos
            {
                Metodo = "Regla Falsa",
                Iteraciones = iter,
                Raiz = xr,
                Yraiz = f(xr),
                ErrorAprox = ea
            };
        }

        // ----- Newton-Raphson -----
        public static ModeloMostrarTodos NewtonRaphson(double xi, double tol, Func<double, double> f, Func<double, double> df)
        {
            double xr = xi;
            double ea = double.MaxValue;
            int iter = 0;

            while (ea > tol)
            {
                double yi = f(xr);
                double dyi = df(xr);

                double xrPrev = xr;
                xr = xr - yi / dyi;

                ea = Math.Abs(xr - xrPrev);
                iter++;
            }

            return new ModeloMostrarTodos
            {
                Metodo = "Newton-Raphson",
                Iteraciones = iter,
                Raiz = xr,
                Yraiz = f(xr),
                ErrorAprox = ea
            };
        }

        // ----- Secante -----
        public static ModeloMostrarTodos Secante(double x1, double x2, double tol, Func<double, double> f)
        {
            double xr = x2;
            double ea = double.MaxValue;
            int iter = 0;

            while (ea > tol)
            {
                double fx1 = f(x1);
                double fx2 = f(x2);

                double xrPrev = xr;
                xr = x2 - ((x1 - x2) * fx2) / (fx1 - fx2);

                ea = Math.Abs(xr - xrPrev);
                x1 = x2;
                x2 = xr;

                iter++;
            }

            return new ModeloMostrarTodos
            {
                Metodo = "Secante",
                Iteraciones = iter,
                Raiz = xr,
                Yraiz = f(xr),
                ErrorAprox = ea
            };
        }

        // ----- Calcular todos los métodos juntos -----
        public static List<ModeloMostrarTodos> CalcularTodos(double xi, double xf, double tol,
                                                          Func<double, double> f,
                                                          Func<double, double> df)
        {
            var lista = new List<ModeloMostrarTodos>
            {
                Biseccion(xi, xf, tol, f),
                ReglaFalsa(xi, xf, tol, f),
                NewtonRaphson(xi, tol, f, df),
                Secante(xi, xf, tol, f)
            };
            return lista;
        }
    }

}

