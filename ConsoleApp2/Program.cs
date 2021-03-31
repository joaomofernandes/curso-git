using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {
            /*Exercicio Aula Membros estáticos

            Console.WriteLine("Digite o valor do raio");
            double raio = double.Parse(Console.ReadLine());
            double circ = Calculadora.circun(raio);
            double vol = Calculadora.volume(raio);

            Console.WriteLine("Circunferencia: " + circ);
            Console.WriteLine("Volume: " + vol);
            Console.ReadLine();

            ############# Exercicio cotação dolar #####################

            Console.WriteLine("Qual é a cotação do dolar");
            double cota = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos dólares vai comprar?");
            int qtd = int.Parse(Console.ReadLine());
            double resultado = cota * qtd;
            double aPagar = resultado + Conversor.Imposto(resultado);
            Console.WriteLine("Valor a ser pago em Euros: " + aPagar);
            Console.ReadLine();*/

            //################# Exercicio Produtos em Stock usando classes #####################3

            /*int qtd;

            Console.WriteLine("Digite os dados do produto:");
            Console.Write("Nome: ");
            string Nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());
            var produto = new Produto(Nome, preco);

            

            double valorTotal = produto.ValorTotalEmStock();
            Console.Clear();
            Console.WriteLine("O que deseja fazer de seguida? Digite o código adjacente");
            Console.WriteLine("1 - Verificar dados do produto");
            Console.WriteLine("2 - Adicionar produtos ao Stock");
            Console.WriteLine("3 - Remover produtos do Stock");
            int opcao = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcao)
            {
                case 1:
                    {
                        Console.WriteLine(produto.ToString());
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Insira a quantidade de produtos que pretende adicionar");
                        qtd = int.Parse(Console.ReadLine());
                        produto.AdicionarProdutos(qtd);
                        Console.WriteLine(produto.ToString());
                        break;
                    }
                case 3:
                    Console.WriteLine("Insira a quantidade de produtos que pretende adicionar");
                    qtd = int.Parse(Console.ReadLine());
                    produto.RemoverProdutos(qtd);
                    Console.WriteLine(produto.ToString());
                    break;


                    //}
                    //Console.ReadLine();



            }*/

            int a = 1;
            int triplo;
            Calculadora.Triple(a, out triplo);
            Console.WriteLine(triplo);

        }
    }
}
