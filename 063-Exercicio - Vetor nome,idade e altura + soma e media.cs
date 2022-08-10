using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, idade;


            N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            int[] idades = new int[N];
            double[] alturas = new double[N];

            // Entrada dos dados

            for(int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                idades[i] = int.Parse(s[1]);
                alturas[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }

            // Calculo de altura media

            double soma = 0.0;

            for(int i = 0; i < N; i++)
            {
                soma = soma + alturas[i];
            }

            double media = soma / N;

            Console.WriteLine("Altura media: " + media.ToString("F2", CultureInfo.InvariantCulture));

            // Percentual de pessoas com menos de 16 anos

            int cont = 0;

            for(int i = 0; i < N; i++)
            {
                if (idades[i] < 16) // algoritimo para descobrir quantos itens "menos de 16"
                {
                    cont++;
                }
            }

            double porcento = (double)cont / N * 100; // regra de tres para porcentagem

            Console.WriteLine("Pessoas com menos de 16 anos: " + porcento.ToString("F1", CultureInfo.InvariantCulture) + "%");

            Console.ReadLine();
            
        }
    }
}
