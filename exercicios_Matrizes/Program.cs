using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios_Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matriz = new double[2, 3];

            //Console.WriteLine(matriz.Length);
            //Console.WriteLine(matriz.Rank);

            //Console.WriteLine(matriz.GetLength(0));
            //Console.WriteLine(matriz.GetLength(1));

            //int n = int.Parse(Console.ReadLine());

            //int [,] mat  = new int[n, n];

            //for(int i = 0; i < n; i++)
            //{
            //    string[] values = Console.ReadLine().Split(' ');

            //    for(int j = 0; j < n; j++)
            //    {
            //        mat[i, j] = int.Parse(values[j]);
            //    }
            //}
            //Console.WriteLine("Main diagonal");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(mat[i, i]);
            //}
            //Console.WriteLine();

            //int count = 0;
            //for(int i = 0; i < n; i++)
            //{
            //    for(int j = 0; j < 0; j++)
            //    {
            //        if(mat[i,j] < 0)
            //        {
            //            count++;
            //        }
            //    }
            //}

            //Console.WriteLine("Negative Numbers: ");
            //Console.ReadLine();

            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            

            for(int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]); 
                }
            }

            Console.WriteLine("Main Diagonal: ");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(mat[i, i]);
            }

            Console.WriteLine("");
            Console.WriteLine("Negative numbers: ");
            int count = 0;

            string variable = (10 > 20) ? "Verdadeiro" : "Falso";

        }
    }
}
