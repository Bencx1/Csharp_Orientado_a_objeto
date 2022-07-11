using System;
using System.Globalization;
namespace Aula9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Amazenando objetos tipo Struct
            Console.WriteLine("Digite o numero de pessoas: ");
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double [n];
            Console.WriteLine("Digite o numero das alturas: ");
            for(int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;

            for(int i = 0; i< n; i++)
            {
                sum += vect[i];
            }

            double avg = sum / n;

            Console.WriteLine("Altura média = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
