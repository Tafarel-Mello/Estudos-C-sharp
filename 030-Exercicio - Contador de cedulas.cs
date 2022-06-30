using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorEntrada, notas100, notas50, notas20, notas10, notas5, notas2, notas1, resto;


            Console.WriteLine("Digite um valor positivo e maior que zero: ");
            valorEntrada = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            notas100 = valorEntrada / 100;
            resto = valorEntrada % 100;

            notas50 = resto / 50;
            resto = resto % 50;

            notas20 = resto / 20;
            resto = resto % 20;

            notas10 = resto / 10;
            resto = resto % 10;

            notas5 = resto / 5;
            resto = resto % 5;

            notas2 = resto / 2;
            resto = resto % 2;

            notas1 = resto;

            Console.WriteLine($"\nOvalor digitado foi " + valorEntrada);
            Console.WriteLine(notas100 + " nota(s) de R$100,00");
            Console.WriteLine(notas50 + " nota(s) de R$50,00");
            Console.WriteLine(notas20 + " nota(s) de R$20,00");
            Console.WriteLine(notas10 + " nota(s) de R$10,00");
            Console.WriteLine(notas5 + " nota(s) de R$5,00");
            Console.WriteLine(notas2 + " nota(s) de R$2,00");
            Console.WriteLine(notas1 + " nota(s) de R$1,00");

        }
    }
}