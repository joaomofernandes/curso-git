using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_DateTime_e_TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Olá Mundo!");
            Console.WriteLine("Bom dia!");
            DateTime d1 = new DateTime(2016, 07, 10);
            DateTime d2 = new DateTime(2019, 06, 09, 22, 01, 45);
            DateTime d3 = new DateTime(2019, 06, 09, 22, 01, 45, 500);

            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;

            DateTime d7 = DateTime.Parse("2004-06-12");
            DateTime d8 = DateTime.Parse("2004-06-12 16:15:47");
            DateTime d9 = DateTime.Parse("12/06/2004 17:01:28");
           

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);

            TimeSpan t1 = new TimeSpan(0, 1, 30);



            Console.ReadLine();
        }
    }
}
