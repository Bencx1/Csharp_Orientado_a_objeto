using Course;
using System;

namespace Aula11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(new int[] { 2, 3 });
            int s2 = Calculator.Sum(new int[] { 2, 3, 4 });

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
