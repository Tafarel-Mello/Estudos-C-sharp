using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, resultado;
            
            Console.WriteLine("Este programa te ajuda com qualquer tabuada!");
            Console.WriteLine("\nDigite um numero inteiro para saber sua tabuada: ");
            N = int.Parse(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
                resultado = i * N;
                Console.WriteLine(i + " x " + N + " = " + resultado);
            }

            Console.ReadLine();

        }
    }
}