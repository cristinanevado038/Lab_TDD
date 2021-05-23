using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculadora
    {
        static void Main(string[] args)
        {
        }

        public static int Suma(int a, int b)
        {
            return a + b;
        }

        public static int Resta(int a, int b)
        {
            return a - b;
        }

        public static int Multiplicacion(int a, int b)
        {
            return a * b;
        }

        public static int Division(int a, int b)
        {
            return a / b;
        }
        
        public static double valorAbsoluto(double num)
        {
            if (num < 0)
            {
                return num * -1;
            }
            return num;
        }

        public static double RaizCuadrada(int a)
        {
            double margen = 0.000001;
            double estimacion = 1.0;
            while (valorAbsoluto((estimacion * estimacion) - a) >= margen)
            {
                double cociente = a / estimacion;
                double promedio = (cociente + estimacion) / 2.0;
                estimacion = promedio;
            }
            return estimacion;
        }
    }
}
