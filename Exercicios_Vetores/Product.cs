using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Vetores
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string nome, double preco)
        {
            Name = nome;
            Price = preco;
        }
    }

    class Aluguer
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Aluguer(string n, string Em)
        {
            Nome = n;
            Email = Em;
        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
