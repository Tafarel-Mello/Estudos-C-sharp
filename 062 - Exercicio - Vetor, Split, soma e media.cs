using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {

            int N;
            double soma, media;
            double[] vet;

            N = int.Parse(Console.ReadLine());
            vet = new double[N];
            soma = 0;

            string[] S = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(S[i], CultureInfo.InvariantCulture);
                soma = soma + vet[i];
            }

            for (int i = 0; i < N; i++)
            {
                Console.Write(vet[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }

            Console.WriteLine();

            media = soma / N;

            Console.WriteLine(soma.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}