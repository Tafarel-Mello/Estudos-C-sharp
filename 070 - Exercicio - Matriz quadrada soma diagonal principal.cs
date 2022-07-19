using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[,] mat;

            N = int.Parse(Console.ReadLine());

            mat = new int[N, N];

            for(int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for(int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            int soma = 0;
            for(int i = 0; i < N; i++)
            {
                soma = soma + mat[i, i];
            }

            Console.WriteLine(soma);

            Console.WriteLine();

        }
    }

}
