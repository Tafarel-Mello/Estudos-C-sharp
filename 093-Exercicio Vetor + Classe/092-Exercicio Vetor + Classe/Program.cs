using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos objetos voce gostaria de registrar?: ");
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for(int i = 0; i < n; i++)
            {
                Console.Write("Qual o nome do produto?: ");
                string name = Console.ReadLine();
                Console.Write("Qual o valor deste produto?: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };
            }

            double soma = 0.0;

            for(int i = 0; i < n; i++)
            {
                soma += vect[i].Price;
            }

            double media = soma / n;

            Console.WriteLine("Preco medio: " + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
