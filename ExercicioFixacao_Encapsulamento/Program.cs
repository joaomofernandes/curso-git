using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p;
            p.X = 10;
            p.Y = 20;

            Console.WriteLine(p);
            
            Console.Write("Entre o número da conta:");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Entre o nome do titular da conta:");
            string nome = Console.ReadLine();
            Console.Write("Deseja fazer um depósito inicial? (s/n)");
            string resposta = Console.ReadLine();
            Console.WriteLine();
            var Conta = new Conta(num, nome);

            if (resposta == "s" || resposta == "S")
            {
                Console.Write("Digite o valor do deposito inicial:");
                double deposInicial = double.Parse(Console.ReadLine());
                Conta.Montante = deposInicial;
                Console.WriteLine(Conta.ToString());
            }
            else if (resposta == "n" || resposta == "N")
                Console.WriteLine("Dados da Conta:\n" + Conta);

            Console.Write("Digite um valor para depósito:");
            double deposito = double.Parse(Console.ReadLine());
            Conta.Deposito(deposito);
            Console.WriteLine("Dados da Conta Atualizados:\n" + Conta);
            Console.WriteLine("");
            Console.Write("Digite o montante que deseja levantar:");
            double levantamento = double.Parse(Console.ReadLine());
            Conta.Levantamento(levantamento);
            Console.WriteLine("Dados da Conta Atualizados:\n" + Conta);
            Console.ReadLine();



        }


    }
}
