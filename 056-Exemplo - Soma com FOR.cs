using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, x, soma;

            Console.WriteLine("Digite o numero de valores a somar: ");
            N = int.Parse(Console.ReadLine());
            soma = 0;

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Digite o valor a somar: ");
                x = int.Parse(Console.ReadLine());
                soma = soma + x;
            }

            Console.WriteLine("A soma dos valores digitados foi: ");
            Console.WriteLine(soma);

            Console.ReadLine();

        }
    }
}

