using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WCF;
using WCF.Dominio.Repositorio;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var provincia = Provincia.BuscarProvincia(7);
        }
        [TestMethod]
        public void TestMethod2()
        {
        }
    }
}
