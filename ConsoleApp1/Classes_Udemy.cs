using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp1
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double calcArea()
        {
            double p = (A + B + C) / 2; //calcular P para a equação da area de Triangulo
            return Math.Sqrt(p + (p - A) * (p - B) * (p - C)) ;
        }
    }

    class Funcionario
    {
        public string Nome;
        public int Idade;
        public double Salario;
        public double Imposto;

        public double SalarioLiquido()
        {
            return Salario - Imposto;

        }

        public void AumentarSalario(double porcentagem)
        {
            Salario = Salario + (SalarioLiquido() * porcentagem / 100);
        }

        public override string ToString()
        {
            return "Nome: " + Nome + "\n" +
                "Salário: " + Salario;
        }
    }

    public class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }
        

        public Produto()
        {
            Quantidade = 10;
        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco) : this()
        {
            _nome = nome;
            Preco = preco;
            
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value == null && value.Length > 1)
                    _nome = value;
            }
        }


        public double ValorTotalEmStock()
        {
            return Quantidade * Preco;
        }
        public void AdicionarProdutos(int quantity)
        {
            Quantidade = Quantidade + quantity;
        }
        public void RemoverProdutos(int quantity)
        {
            Quantidade = Quantidade - quantity;
        }

        

        public override string ToString()
        {
            return "Nome: " + _nome + " " + "\n"
                + "Preço: " + Preco + "£" + "\n"
                + "Quantidade: " + Quantidade + "\n" 
                + "Valor Total em Stock: "+ ValorTotalEmStock() + "£";
        }
        
        
    }
    class Rectangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return (Largura + Altura) * 2;
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }

        public override string ToString()
        {
            return "AREA: " + Area() + "\n"
                + "PERIMETRO: " + Perimetro() + "\n"
                + "DIAGONAL: " + Diagonal();
        }
    }
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;
        public double NotaFinal;

        public double Media()
        {
            return (Nota1 + Nota2 + Nota3 )/ 3 ;
        }

        public string AprovadoReprovado(double media)
        {
            media = Media();
            double aFaltar = 60 - Media();
            if (media < 60)
                return "REPROVADO" + "\n" + "FALTARAM " + aFaltar;
            else
                return "APROVADO";

        }
    }
}
