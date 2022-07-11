using System;
namespace Aula4
{
    internal class Calculadora
    {
        public static double pi = 3.14;

        public static double Circunferencia(double raio)
        {
            return 2.0 * pi * raio;
        }

        public static double Volume(double r)
        {
            return 4.0 / 3.0 * pi * Math.Pow(r, 3.0);
        }
    }
}
