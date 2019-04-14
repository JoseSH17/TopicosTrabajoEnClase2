using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void TestMethod1()
        {
            var elClienteWcf = new MyEstacionamiento.MyEstacionamientoClient();

            DateTime fechaInicio = DateTime.Parse("2005-01-03 00:00:00.000");
            DateTime fechaFin = DateTime.Parse("2005-03-03 00:00:00.000");

            var cantidadDeRegistrosEsperada = 402;
            var cantidadDeRegistrosReal = 0;

            var elResultado = elClienteWcf.ListarRegistrosPorRangoDeFechas(fechaInicio, fechaFin);
            if (elResultado != null)
            cantidadDeRegistrosReal = elResultado.Length;
            Console.WriteLine(string.Format("La cantidad de registros consultados es {0}.", elResultado.Length));
            Assert.IsTrue(cantidadDeRegistrosEsperada == cantidadDeRegistrosReal);
        }
        [TestMethod]
        public void TestMethod2()
        {
        }
    }
}
