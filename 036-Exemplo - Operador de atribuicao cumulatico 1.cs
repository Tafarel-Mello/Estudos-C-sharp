using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutos;
            double conta;

            minutos = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            conta = 50;
            if(minutos > 100)
            {
                conta = conta + (minutos - 100) * 2.0; // conta += (minutos -100) * 2.0; mesma coisa
            }

            Console.WriteLine("Valor a pagar: R$ " + conta.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}