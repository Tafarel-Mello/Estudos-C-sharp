using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;
            int idade1, idade2;
            double media;
            string[] vet;

            Console.WriteLine("Digite o nome e a idade da primeira pessoa: ");
            vet = Console.ReadLine().Split(' ');

            nome1 = vet[0];
            idade1 =int.Parse(vet[1]); // para passar de string para int

            Console.WriteLine("\nDigite o nome e a idade da segunda pessoa: ");
            vet = Console.ReadLine().Split(' ');

            nome2 = vet[0];
            idade2 = int.Parse(vet[1]); // para passar de string para int

            media = (idade1 + idade2) / 2.0;

            Console.WriteLine("A idade media de " + nome1 + " e " + nome2 + " e igual a " + media.ToString("F1", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}