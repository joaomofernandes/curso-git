using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercicios_Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            //############### Exercicio Vetores 1 #########################
            /*Console.Write("Digite um  numero inteiro refente ao tamanho do vetor: ");
            int n = int.Parse(Console.ReadLine());

            double[] vetor = new double[n];

            for(int i = 0; i < n; i++)
            {
                Console.Write("Digite um valor: ");
                vetor[i] = int.Parse(Console.ReadLine());

            }

            double sum = 0.0;
            for(int i = 0; i<n; i++)
            {
                sum += vetor[i];
            }

            Console.WriteLine(sum);
            

            double avg = sum / n;
            Console.WriteLine("Altura Média: " + avg);
            Console.ReadLine();*/

            // ######################## Exercicio Vetores com Produtos #####################

            /*Console.WriteLine("Digite o número de produtos");
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Please type the name of the product:");
                string name = Console.ReadLine();
                Console.WriteLine("Please insert the price of the product:");
                double price = double.Parse(Console.ReadLine());
                vect[i] = new Product(name, price);

                
            }
            double Sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                Sum += vect[i].Price;
            }

            double avg = Sum / n;

            Console.WriteLine("Preço médio: " + avg);
            Console.ReadLine();*/

            // ######################### Exercicio fixação vetores ##########################

            Aluguer[] quarto = new Aluguer[10];

            Console.WriteLine("Indique a quantidade de quartos que serão alugados");
            int qtd = int.Parse(Console.ReadLine());

            for(int i = 0; i < qtd; i++)
            {
                Console.WriteLine("############## " + "ALUGUER " + (i+1) + " #####################");
                Console.WriteLine("Por favor indique os dados referentes ao aluguer(nome, email, nº do quarto)");
                string dados = Console.ReadLine();
                string[] info = dados.Split(',');
                string nome = info[0];
                string email = info[1];
                int numQuarto = Convert.ToInt32(info[2]);
                quarto[numQuarto] = new Aluguer(nome, email);
            }

            Console.Clear();
            
            Console.WriteLine("Quartos ocupados:");
            for(int i = 0; i < 9; i++)
            {

                if(quarto[i] != null)
                {
                    Console.WriteLine(i + ":" + quarto[i]);
                }
            }

            
            Console.ReadLine();

        }
    }
}
