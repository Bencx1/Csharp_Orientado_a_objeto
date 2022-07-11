using System;
using System.Globalization;
namespace Aula6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("Tv", 500.00, 10);

            p.Nome = "TV 4k";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
        }
    }
}
