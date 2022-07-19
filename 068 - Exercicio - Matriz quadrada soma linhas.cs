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
            int[] vet;

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

            vet = new int[N];
            

            for(int i = 0; i < N; i++)
            {
                int soma = 0;
                for (int j = 0; j < N; j++)
                {
                    soma = soma + mat[i, j];
                }

                vet[i] = soma;
            }

            for(int i = 0; i < N; i++)
            {
                Console.WriteLine(vet[i]);
            }

            
            Console.ReadLine();
        }
    }

}
