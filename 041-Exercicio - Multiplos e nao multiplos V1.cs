using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, divis;

            Console.WriteLine("Digite o primeiro numero inteiro: ");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o segundo numero inteiro: ");
            B = int.Parse(Console.ReadLine());

            if (A < B)
            {
                divis = B % A;
            }
            else
            {
                divis = A % B;
            }

            if (divis == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }

            Console.ReadLine();
        }
    }
}