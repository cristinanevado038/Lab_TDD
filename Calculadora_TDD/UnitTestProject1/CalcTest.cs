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
        [TestMethod]
        public void TestRestaPos()
        {
            //Arrange
            int a = 6;
            int b = 2;
            int resEsperado = 4;
            int resOperacion = 0;

            //Act
            resOperacion = Calculadora.Calculadora.Resta(a, b);

            //Assert
            Assert.AreEqual(resEsperado, resOperacion);
        }
        [TestMethod]
        public void TestRestaNeg()
        {
            //Arrange
            int a = -1;
            int b = 9;
            int resEsperado = -10;
            int resOperacion = 0;

            //Act
            resOperacion = Calculadora.Calculadora.Resta(a, b);

            //Assert
            Assert.AreEqual(resEsperado, resOperacion);
        }
        [TestMethod]
        public void TestMultiplicacionPos()
        {
            //Arrange
            int a = 5;
            int b = 2;
            int resEsperado = 10;
            int resOperacion = 0;

            //Act
            resOperacion = Calculadora.Calculadora.Multiplicacion(a, b);

            //Assert
            Assert.AreEqual(resEsperado, resOperacion);
        }
        [TestMethod]
        public void TestMultiplicacionNeg()
        {
            //Arrange
            int a = -3;
            int b = 9;
            int resEsperado = -27;
            int resOperacion = 0;

            //Act
            resOperacion = Calculadora.Calculadora.Multiplicacion(a, b);

            //Assert
            Assert.AreEqual(resEsperado, resOperacion);
        }
    }
}
