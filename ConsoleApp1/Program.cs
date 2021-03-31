using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string password_acesso = "2002";
            //bool validacao = false;

            //Console.Write("Por favor insira a password de acesso:");
            //string pass_introduzida = Console.ReadLine();

            //while(validacao == false)
            //{
            //    if(pass_introduzida != password_acesso)
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Password Inválida");
            //        validacao = false;
            //        Console.Write("Por favor insira a password de acesso:");
            //        pass_introduzida = Console.ReadLine();
            //        if (pass_introduzida == password_acesso)
            //        {
            //            Console.Clear();
            //            validacao = true;
            //            Console.WriteLine("Acesso permitido");
            //        }
            //        else
            //        {
            //            Console.Clear();
            //            Console.WriteLine("Acesso Inválido");
            //            Console.Write("Por favor insira a password de acesso:");
            //        }
            //        Console.ReadLine();
            //    }
            //    else if(pass_introduzida == password_acesso)
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Acesso permitido");
            //        validacao = true;
            //        Console.ReadLine();
            //    }
            //}

            //Console.WriteLine("Digite um número inteiro");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite outro número inteiro");
            //int y = int.Parse(Console.ReadLine());
            //while(x != 0 && y != 0)
            //{
            //    if(x > 0 && y > 0)
            //    {
            //        Console.WriteLine("Primeiro Quadrante");
            //    }
            //    else if (x < 0 && y > 0)
            //    {
            //        Console.WriteLine("Segundo Quadrante");
            //    }
            //    else if (x < 0 && y < 0)
            //    {
            //        Console.WriteLine("Terceiro Quadrante");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Quarto Quadrante");
            //    }

            //    Console.WriteLine("Digite um número inteiro");
            //    x = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite outro número inteiro");
            //    y = int.Parse(Console.ReadLine());
            //}

            //################### Exercicio Funcionários usando classe #############
            //var func1 = new Funcionario();
            //var func2 = new Funcionario();

            //Console.WriteLine("Insira os nome do 1º funcionário");
            //func1.nome = Console.ReadLine();
            //Console.WriteLine("Insira a idade do 1º funcionário");
            //func1.idade = int.Parse(Console.ReadLine());
            //Console.WriteLine("Agora insira o salário do 1º funcionário");
            //func1.salário = double.Parse(Console.ReadLine());
            //Console.Clear();

            //Console.WriteLine("Insira os nome do 2º funcionário");
            //func2.nome = Console.ReadLine();
            //Console.WriteLine("Insira a idade do 2º funcionário");
            //func2.idade = int.Parse(Console.ReadLine());
            //Console.WriteLine("Agora insira o salário do 2º funcionário");
            //func2.salário = double.Parse(Console.ReadLine());
            //Console.Clear();

            //if (func1.idade > func2.idade)
            //    Console.WriteLine("Pessoa mais velha: " + func1.nome);
            //else
            //    Console.WriteLine("Pessoa mais velha: " + func2.nome);

            //double salarioMedio = (func1.salário + func2.salário) / 2;
            //Console.WriteLine("Salário Médio: " + salarioMedio);
            //Console.ReadLine();


            //########## Calcular area de triangulo usando classes###################

            //var medidasTriangulo = new Triangulo();

            //Console.WriteLine("Insira as medidas do triangulo.");
            //medidasTriangulo.A = double.Parse(Console.ReadLine());
            //medidasTriangulo.B = double.Parse(Console.ReadLine());
            //medidasTriangulo.C = double.Parse(Console.ReadLine());

            //var area = medidasTriangulo.calcArea();
            //Console.WriteLine("Area do Triângulo: " + area);
            //Console.ReadLine();

            //################# Exercicio Produtos em Stock usando classes #####################3
            //var produto = new Produto();
            //int qtd = 0;

            //Console.WriteLine("Digite os dados do produto:");
            //Console.Write("Nome: ");
            //produto.Nome = Console.ReadLine();  
            //Console.Write("Preço: ");
            //produto.preco = double.Parse(Console.ReadLine()); 
            //Console.Write("Quantidade: ");
            //produto.quantidade = int.Parse(Console.ReadLine());
            //double valorTotal = produto.ValorTotalEmStock();
            //Console.Clear();
            //Console.WriteLine("O que deseja fazer de seguida? Digite o código adjacente");
            //Console.WriteLine("1 - Verificar dados do produto");
            //Console.WriteLine("2 - Adicionar produtos ao Stock");
            //Console.WriteLine("3 - Remover produtos do Stock");
            //int opcao = int.Parse(Console.ReadLine());
            //Console.Clear();
            //switch(opcao)
            //{
            //    case 1:
            //        {
            //            Console.WriteLine(produto.ToString());
            //            break;
            //        }
            //    case 2:
            //        {
            //            Console.WriteLine("Insira a quantidade de produtos que pretende adicionar");
            //            qtd = int.Parse(Console.ReadLine());
            //            produto.AdicionarProdutos(qtd);
            //            Console.WriteLine(produto.ToString());
            //            break;
            //        }
            //    case 3:
            //        Console.WriteLine("Insira a quantidade de produtos que pretende adicionar");
            //        qtd = int.Parse(Console.ReadLine());
            //        produto.RemoverProdutos(qtd);
            //        Console.WriteLine(produto.ToString());
            //        break;


            //}
            //Console.ReadLine();

            // ############### Calculos Rectangulo usando classes ####################

            //var rectangulo = new Rectangulo();
            //Console.WriteLine("Insira a largura e a altura do retângulo");
            //rectangulo.Largura = double.Parse(Console.ReadLine());
            //rectangulo.Altura = double.Parse(Console.ReadLine());

            //Console.WriteLine(rectangulo.ToString());
            //Console.ReadLine();


            //################################### Dados de salário de funcionário ##################
            //var func = new Funcionario();
            //Console.Write("Nome: ");
            //func.Nome = Console.ReadLine();
            //Console.Write("Salário Bruto: ");
            //func.Salario = double.Parse(Console.ReadLine());
            //Console.Write("Imposto: ");
            //func.Imposto = double.Parse(Console.ReadLine());

            //func.Salario = func.SalarioLiquido();


            //Console.Write("");
            //Console.WriteLine(func.ToString());

            //Console.WriteLine("Digite a percentagem para aumentar o salário");
            //double percentagem = double.Parse(Console.ReadLine());
            //func.AumentarSalario(percentagem);

            //Console.WriteLine("Dados atualizados: " + func.ToString());
            //Console.ReadLine();


            //################ EXERCICIO ALUNOS ####################

            //Aluno aluno = new Aluno();
            //Console.WriteLine("Indique o nome do aluno");
            //aluno.Nome = Console.ReadLine();
            //Console.WriteLine("Por favor indique as notas do aluno");
            //aluno.Nota1 = double.Parse(Console.ReadLine());
            //aluno.Nota2 = double.Parse(Console.ReadLine());
            //aluno.Nota3 = double.Parse(Console.ReadLine());
            //double media = aluno.Media();

            //Console.WriteLine(aluno.AprovadoReprovado(media));
            //Console.ReadLine();

            //############### FUNCÕES STRING #######################3

            string original = "abcde FGHIJ ABC def";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();
            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);

            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");

            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");

            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("Substring: -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("IndexOf: -" + n1 + "-");
            Console.WriteLine("LastIndexOf: -" + n2 + "-");
            Console.WriteLine("Substring: -" + s4 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: -" + b1 + "-");
            Console.WriteLine("IsNullOrWhiteSpace: -" + b2 + "-");



        }

        static int Maior(int a, int b, int c)
        {
            int maior;
            if(a > b && a > c)
            {
                maior = a;
                
            }
            else if (b > c)
            {
                maior = b;
            }
            else
            {
                maior = c;
            }

            return maior;
        }
    }
}
