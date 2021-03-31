using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Calculadora
    {
        public static double pi = 3.14;
        public static double circun(double r)
        {
            return 2.0 * pi * r;
        }

        public static double volume(double r)
        {
            return 4.0 / 3.0 * pi * Math.Pow(r, 3);
        }

        public static double Sum(params double[] numbers)
        {
            double sum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        public static void Triple(int origin, out int result)
        {
            result = origin + 3;
        }
    }

    class Conversor
    {
        public static double Imposto(double valor)
        {
            return valor * 0.06;
        }
    }
}
