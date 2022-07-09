using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {

            int x, y, min, max, soma;

            Console.WriteLine("Digite dois valores para servir como intervalo: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if(x < y)
            {
                min = x;
                max = y;
            }
            else
            {
                min = y;
                max = x;
            }

            soma = 0;
            for (int i = min + 1; i < max; i++)
            {
                if (i % 2 != 0)
                {
                    soma = soma + i;
                }
            }

            Console.WriteLine($"A soma dos valores impares no intervalo desejado foi de: " + soma);
            Console.ReadLine();

        }
    }
}