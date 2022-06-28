using System;
using System.Globalization;


namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, media, peso1, peso2, somaPeso;

            peso1 = 3.5;
            peso2 = 7.5;
            somaPeso = peso1 + peso2;

            Console.WriteLine("Digite a nota 1: ");
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a nota 2: ");
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            media = ((A * peso1) + (B * peso2)) / somaPeso;

            Console.WriteLine($"MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));


        }
    }
}