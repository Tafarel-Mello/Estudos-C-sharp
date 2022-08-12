using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo x = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retangulo: ");
            x.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = x.Area();
            double perimetro = x.Perimetro();
            double diagonal = x.Diagonal();

            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
