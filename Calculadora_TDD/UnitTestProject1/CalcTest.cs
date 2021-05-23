using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void TestSumaPos()
        {
            //Arrange
            int a = 2;
            int b = 5;
            int resEsperado = 7;
            int resOperacion = 0;

            //Act
            resOperacion = Calculadora.Calculadora.Suma(a, b);

            //Assert
            Assert.AreEqual(resEsperado, resOperacion);
        }
        [TestMethod]
        public void TestSumaNeg()
        {
            //Arrange
            int a = -1;
            int b = 9;
            int resEsperado = 8;
            int resOperacion = 0;

            //Act
            resOperacion = Calculadora.Calculadora.Suma(a, b);

            //Assert
            Assert.AreEqual(resEsperado, resOperacion);
        }
    }
}
