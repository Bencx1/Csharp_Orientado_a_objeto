using System;
using System.Globalization;
namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1, f2;

            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Digite o nome do primeiro funcionario: ");
            f1.nome = Console.ReadLine();

            Console.WriteLine("Digite o salario do primeiro funcionario: ");
            f1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o nome do segundo funcionario: ");
            f2.nome = Console.ReadLine();

            Console.WriteLine("Digite o salario do segundo funcionario: ");
            f2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (f1.salario + f2.salario) / 2.0;

            Console.WriteLine("Salario médio =  " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
