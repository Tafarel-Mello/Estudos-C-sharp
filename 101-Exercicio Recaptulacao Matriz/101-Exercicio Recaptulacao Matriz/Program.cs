using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.Write("Digite o numero de linhas e colunas: ");
            string[] vet1 = Console.ReadLine().Split(' ');

            x = int.Parse(vet1[0]);
            y = int.Parse(vet1[1]);

            int[,] mat = new int[x, y];
            int cont = 1;

            for (int i = 0; i < x; i++)
            {
                Console.Write("Entre os valores para a linha " + cont + ": ");
                string[] vet2 = Console.ReadLine().Split(' ');
                for (int j = 0; j < y; j++)
                {
                    mat[i, j] = int.Parse(vet2[j]);
                }
                cont = cont + 1;
            }

            Console.WriteLine();

            Console.Write("Entre o valor a encontrar: ");
            int valorLocalizar = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (mat[i, j] == valorLocalizar)
                    {
                        Console.WriteLine("Posicao: " + i + ", " + j);
                        if (j > 0)
                        {
                            Console.WriteLine("A esquerda: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("A cima: " + mat[i - 1, j]);
                        }
                        if (j < y - 1)
                        {
                            Console.WriteLine("A direita: " + mat[i, j + 1]);
                        }
                        if (i < x - 1)
                        {
                            Console.WriteLine("Abaixo: " + mat[i + 1, j]);
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}


