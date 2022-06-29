using System;
using System.Globalization;


namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, media, peso1, peso2, peso3, somaPeso;

            peso1 = 2;
            peso2 = 3;
            peso3 = 5;
            somaPeso = peso1 + peso2 + peso3;

            Console.WriteLine("Digite a nota 1: ");
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a nota 2: ");
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a nota 3: ");
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = ((A * peso1) + (B * peso2) + (C * peso3)) / somaPeso;

            Console.WriteLine($"MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));


        }
    }
}