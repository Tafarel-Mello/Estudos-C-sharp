using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, precoMetroQuad, area, preco;

            Console.WriteLine("Digite a largura do seu terreno: ");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o comprimento do seu terreno: ");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Qual o valor por metro quadrado: ");
            precoMetroQuad = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;

            preco = area * precoMetroQuad;

            Console.WriteLine($"\nA area do terreno sera de: " + area.ToString("F2", CultureInfo.InvariantCulture) + " metros quadrados");
            Console.WriteLine($"\nO valor do terreno sera de: R$ " + preco.ToString("F2", CultureInfo.InvariantCulture) + " reais");

            Console.ReadLine();

        }
    }
}