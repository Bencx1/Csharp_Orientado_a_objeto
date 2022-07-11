using System;
using System.Globalization;
namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria Conta;

            Console.WriteLine("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o nome do titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Havera deposito inicial? ");
            char resp = char.Parse(Console.ReadLine());
            if(resp == 's' || resp == 'S')
            {
                Console.WriteLine("Digite o valor do deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                Conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(Conta);

            Console.WriteLine();
            Console.Write("Entre com o valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(Conta);

            Console.WriteLine();
            Console.WriteLine("Entre com valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(Conta);
        }
    }
}
