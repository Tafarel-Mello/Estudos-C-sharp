using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salarioFixo, vendasMes, salarioTotal;

            nome = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vendasMes = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salarioTotal = salarioFixo + (vendasMes * 0.15);

            Console.WriteLine("TOTAL = R$ " + salarioTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}