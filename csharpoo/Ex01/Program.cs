using System;
using System.Globalization;

namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1, p2;

            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Digite o nome da primeira pessoa: ");
            p1.nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da primeira pessoa: ");
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da segunda pessoa: ");
            p2.nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da segunda pessoa: ");
            p2.idade = int.Parse(Console.ReadLine());
            
            if(p1.idade > p2.idade)
            {
                Console.WriteLine("A pessoa mais velha " + p1.nome);
            }
            else
            {
                Console.WriteLine("A pessoa mais velha " + p2.nome);
            }
        }
    }
}
