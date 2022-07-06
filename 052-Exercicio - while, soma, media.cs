using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {

            double idade, soma, media;
            int cont;

            soma = 0.0;
            cont = 0;

            idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (idade >= 0)
            {
                soma = soma + idade;
                cont = cont + 1;
                idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            if (cont == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                media = soma / cont;
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.ReadLine();

        }
    }
}
