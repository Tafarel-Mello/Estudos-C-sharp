using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, area, n, A;

            n = 3.14159;

            Console.WriteLine("Digite o raio do circulo: ");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = n * Math.Pow(raio, 2);
            A = area;

            Console.WriteLine("E area do circulo resulta em=" + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}