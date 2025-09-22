using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RaicesLogica.Servicio;

namespace RaicesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Biseccion_RaizCorrecta()
        {
            // Arrange: intervalo válido  
            var resultado = new Resultado();
            double xi = 0.0;
            double xf = 0.5;
            double eamax = 0.001;

            // Act  
            var iteraciones = resultado.Biseccion(xi, xf, eamax);

            // Verificar que se generaron iteraciones
            if (iteraciones.Count == 0)
            {
                throw new InvalidOperationException("No se generaron iteraciones. Revisa xi, xf o la función.");
            }


            var ultimaIteracion = iteraciones.Last(); // Ensure iteraciones is a collection  
            double xrFinal = ultimaIteracion.Xr;

            // Assert  
            double raizEsperada = 0.449951171875; // Cambiar según la función  
            Assert.AreEqual(raizEsperada, xrFinal, 0.001,
                "La raíz calculada no coincide con la esperada.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Biseccion_IntervaloIncorrecto()
        {
            var resultado = new Resultado();
            double xi = 2.0;
            double xf = 2.0;
            double eamax = 0.001;

            // Esto debería lanzar excepción  
            resultado.Biseccion(xi, xf, eamax);
        }



        [TestMethod]
        public void ReglaFalsa_RaizCorrecta()
        {
            // Arrange
            var resultado = new Resultado();
            double xi = 0.2;
            double xf = 1.5;
            double eamax = 0.001;

            // Act
            var iteraciones = resultado.ReglaFalsa(xi, xf, eamax);
            var ultimaIteracion = iteraciones[iteraciones.Count - 1];
            double xrFinal = ultimaIteracion.Xr;

            // Assert
            double raizEsperada = 0.44995; // raíz correcta de F(x) en ese intervalo
            Assert.AreEqual(raizEsperada, xrFinal, 0.001, "La raíz calculada no coincide con la esperada.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ReglaFalsa_IntervaloIncorrecto()
        {
            var resultado = new Resultado();
            double xi = 2.0;
            double xf = 2.0;
            double eamax = 0.001;

            // Esto debería lanzar excepción  
            resultado.ReglaFalsa(xi, xf, eamax);
        }

    }
}


