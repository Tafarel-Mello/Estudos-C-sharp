using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, maior;
            int[,] mat;

            N = int.Parse(Console.ReadLine());

            mat = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for(int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            int[] vet = new int[N];
            

            for(int i = 0; i < N; i++)
            {
                maior = 0;
                for (int j = 0; j < N; j++)
                {
                    if(mat[i, j] > maior)
                    {
                        maior = mat[i, j];
                        vet[i] = maior;
                    }
                    
                }
            }

            for(int i = 0; i < N; i++)
            {
                Console.WriteLine(vet[i]);
            }

            
            Console.ReadLine();
        }
    }

}
