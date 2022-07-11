using System;
using System.Globalization;
namespace Aula5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Aula 3 adaptada Construtores!!!
            Console.WriteLine("Entre os dados do produto: ");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
          /*  Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());*/

            //Produto p = new Produto(nome, preco, quantidade); construtor 1

            Produto p = new Produto(nome, preco); //Construtor 2 sobrecarga

            //   Produto p3 = new Produto { Nome = "TV", Preco = 500.00, Quantidade = 20 }; Sintaxe alternativa para inicializar valores 

            Console.WriteLine();
            Console.WriteLine("Dados do produto : " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adcionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);   
        }
    }
}
