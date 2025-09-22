using RaicesLogica.Funciones;
using RaicesLogica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaicesLogica.Servicio
{
    public class Resultado
    {

        public List<Iteracion> Biseccion(double xi, double xf, double eamax)
        {
            // Lista que almacenará todas las iteraciones realizadas

            var iteraciones = new List<Iteracion>();
            
            double xr;               // Valor actual de la raíz aproximada
            
            double xrAnterior = 0;   // Valor de la raíz de la iteración anterior
            
            double ea = double.PositiveInfinity; // Error aproximado inicial muy grande
            
            int contador = 0;        // Contador de iteraciones

            // Validación: xi y xf no pueden ser iguales
            if (xi == xf)
                throw new ArgumentException("xi y xf no pueden ser iguales");

            // Evaluamos la función en los extremos
            double fxi = FuncionesMatematicas.F(xi);
            double fxf = FuncionesMatematicas.F(xf);

            // Validación: para aplicar bisección debe cumplirse que f(xi) y f(xf) tengan signos opuestos
            if (fxi * fxf > 0)
                throw new ArgumentException("f(xi) y f(xf) deben tener signos opuestos");

            // Ciclo iterativo hasta que el error sea menor al error máximo permitido
            do
            {
                contador++;

                // Fórmula de bisección: punto medio del intervalo
                xr = (xi + xf) / 2.0;

                // Evaluamos la función en xr
                double fxr = FuncionesMatematicas.F(xr);

                // Actualizamos los intervalos dependiendo del signo
                if (fxi * fxr < 0.0)   // La raíz está entre xi y xr
                {
                    xf = xr;

                }
                else if (fxi * fxr > 0.0) // La raíz está entre xr y xf
                {
                    xi = xr;

                }
                else
                {
                    ea = 0; // Encontramos raíz exacta
                }

                // A partir de la segunda iteración calculamos el error relativo
                if (contador > 1)
                    ea = FuncionesMatematicas.ErrorRelativo(xr, xrAnterior);

                // Guardamos esta iteración en la lista
                iteraciones.Add(new Iteracion
                {
                    Numero = contador,
                    Xi = xi,
                    Xf = xf,
                    Xr = xr,
                    FxR = fxr,
                    Error = ea
                });

                // Actualizamos xrAnterior para la siguiente iteración
                xrAnterior = xr;

            } while (ea > eamax); // El ciclo termina cuando el error es suficientemente pequeño

            return iteraciones;
        }

        public List<Iteracion> ReglaFalsa(double xi, double xf, double eamax)
        {
            var iteraciones = new List<Iteracion>();
            int contador = 0;

            double xr = 0;
            double xrAnterior = 0;
            double ea = double.PositiveInfinity;

            // Validación: xi y xf no pueden ser iguales
            if (xi == xf)
                throw new ArgumentException("xi y xf no pueden ser iguales");

            // Evaluamos la función en los extremos
            double fxi = FuncionesMatematicas.F(xi);
            double fxf = FuncionesMatematicas.F(xf);

            // Validación: f(xi) y f(xf) deben tener signos opuestos
            if (fxi * fxf > 0)
                throw new ArgumentException("f(xi) y f(xf) deben tener signos opuestos");

            do
            {
                contador++;

                // Fórmula de Regla Falsa
                xr = (xi * fxf - xf * fxi) / (fxf - fxi);
                double fxr = FuncionesMatematicas.F(xr);

                // Actualizamos los intervalos y sus valores de f(x)
                if (fxi * fxr < 0)   // La raíz está entre xi y xr
                {
                    xf = xr;
                    fxf = fxr; //actualizar fxf
                }
                else if (fxi * fxr > 0) // La raíz está entre xr y xf
                {
                    xi = xr;
                    fxi = fxr; // actualizar fxi
                }
                else
                {
                    ea = 0; // Raíz exacta encontrada
                }

                // Calculamos el error relativo a partir de la segunda iteración
                if (contador > 1)
                    ea = FuncionesMatematicas.ErrorRelativo(xr, xrAnterior);

                // Guardamos la iteración
                iteraciones.Add(new Iteracion
                {
                    Numero = contador,
                    Xi = xi,
                    Xf = xf,
                    Xr = xr,
                    FxR = fxr,
                    Error = ea
                });

                // Actualizamos xrAnterior
                xrAnterior = xr;

            } while (ea > eamax);

            return iteraciones;
        }

    }
}
