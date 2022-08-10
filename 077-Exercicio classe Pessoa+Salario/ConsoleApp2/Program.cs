using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1, pessoa2;
            double soma, media;

            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();


            Console.WriteLine("Digite seu nome: ");
            pessoa1.A = Console.ReadLine();
            Console.WriteLine("Agora digite seu salario: ");
            pessoa1.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Digite seu nome: ");
            pessoa2.A = Console.ReadLine();
            Console.WriteLine("Agora digite seu salario: ");
            pessoa2.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            soma = pessoa1.B + pessoa2.B;
            media = soma / 2.0;

            Console.WriteLine("Salario medio: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
