using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod1, qntd1;
            double soma, preco1;


            Console.WriteLine("Digite o item desejado e a quantidade deste item: ");
            string[] vet = Console.ReadLine().Split(' ');

            cod1 = int.Parse(vet[0]);
            qntd1 = int.Parse(vet[1]);

            switch (cod1)
            {
                case 1:
                    preco1 = 4.0;
                    break;
                case 2:
                    preco1 = 4.5;
                    break;
                case 3:
                    preco1 = 5.0;
                    break;
                case 4:
                    preco1 = 2.0;
                    break;
                default:
                    preco1 = 1.5;
                    break;
            }

            soma = preco1 * qntd1;

            Console.WriteLine("Total: R$ " + soma.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}