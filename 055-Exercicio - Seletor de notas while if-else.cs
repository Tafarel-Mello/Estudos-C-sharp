using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota, soma, media;
            int cont;

            cont = 0;
            soma = 0.0;

            

            while (cont < 2)
            {
                nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (nota >= 0.0 && nota <= 10.0)
                {
                    cont = cont + 1;
                    soma = soma + nota;
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }

            }

            media = (double) soma / cont;

            Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}