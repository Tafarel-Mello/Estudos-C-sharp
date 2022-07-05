using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, soma;

            Console.WriteLine("Digite os valores inteiros para somar ou ZERO para parar: ");
            X = int.Parse(Console.ReadLine());
            soma = X;

            while(X != 0)
            {
                X = int.Parse(Console.ReadLine());
                soma = soma + X;
            }

            Console.WriteLine(soma);
            Console.ReadLine();

        }
    }
}