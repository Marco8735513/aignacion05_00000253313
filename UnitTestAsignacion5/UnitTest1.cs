using System;
using System.Collections.Generic;
using aignacion05_00000253313.MetodoNewtonSecuencia.Funciones;
using aignacion05_00000253313.MetodoNewtonSecuencia.Modelo;
using aignacion05_00000253313.MetodoNewtonSecuencia.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAsignacion5
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange: valores iniciales y tolerancia
            double xi = 1;                     // Valor inicial
            double eamax = 0.01;               // Error máximo permitido
            Func<double, double> f = Funciones.F;            // Función a evaluar
            Func<double, double> df = Funciones.Fderivada;  // Derivada de la función

            // Act: ejecutar Newton-Raphson
            List<NewtonResultado> resultados = Resultado.Calcular(xi, eamax, f, df);

            // Obtener la última iteración
            NewtonResultado ultima = resultados[resultados.Count - 1];

            // Raíz esperada aproximada según tus cálculos previos
            double raizEsperada = 0.4501;

            // Assert: Comprobamos que Xr esté dentro de la tolerancia
            Assert.AreEqual(raizEsperada, ultima.Xr, 0.0001, "Newton-Raphson no calculó la raíz correctamente.");

            // Assert: Comprobamos que el error final sea menor o igual al error máximo permitido
            Assert.IsTrue(ultima.Ea <= eamax, "El error final es mayor al máximo permitido.");
        }

        [TestMethod]
        public void Secante_RaizFinalCorrecta()
        {
            // Arrange
            double x1 = 2.0;
            double x2 = 3.0;
            double eamax = 0.1;

            // Act
            List<SecanteResultado> resultados = Resultado.Calcular2(x1, x2, eamax);

            // Tomamos la última iteración
            SecanteResultado ultima = resultados[resultados.Count - 1];

            // Raíz esperada aproximada (puedes usar el resultado que obtuviste en tu programa)
            double raizEsperada = 2.4991;

            // Assert: Xr dentro de tolerancia
            Assert.AreEqual(raizEsperada, ultima.Xr, 0.0001, "Secante no calculó la raíz correctamente.");

            // Assert: El error final <= eamax
            Assert.IsTrue(ultima.Ea <= eamax, "El error final es mayor al máximo permitido.");
        }

        [TestMethod]
        public void Secante_IteracionesValidas()
        {
            // Arrange
            double x1 = 2.0;
            double x2 = 3.0;
            double eamax = 0.1;

            // Act
            List<SecanteResultado> resultados = Resultado.Calcular2(x1, x2, eamax);

            // Assert: Al menos 1 iteración
            Assert.IsTrue(resultados.Count > 0, "No se generaron iteraciones.");

            // Assert: Todos los valores de fx1, fx2 y Xr no son NaN
            foreach (var r in resultados)
            {
                Assert.IsFalse(double.IsNaN(r.fx1), "fx1 es NaN");
                Assert.IsFalse(double.IsNaN(r.fx2), "fx2 es NaN");
                Assert.IsFalse(double.IsNaN(r.Xr), "Xr es NaN");
            }
        }

    }
}
