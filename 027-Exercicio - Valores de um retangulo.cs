using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            double _base, altura, area, perimetro, diagonal;

            Console.WriteLine("Digite o valor da base do retangulo em mm: ");
            _base = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nDigite o valor da altura do retangulo em mm: ");
            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = _base * altura;

            perimetro = 2 * (_base + altura); // ou = _base * 2 + altura * 2

            diagonal = Math.Sqrt( Math.Pow(_base, 2.0) + Math.Pow(altura, 2.0)); // teorema de pitagoras

            Console.WriteLine("Area = " + area.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("\nPerimetro = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("\nDiagonal = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}