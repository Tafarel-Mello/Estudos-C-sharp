using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            int N, ano, mes, dia, resto;

            Console.WriteLine("Digite uma quantidade de dias: ");
            N = int.Parse(Console.ReadLine());

            ano = N / 365;
            resto = N % 365;

            mes = resto / 30;
            dia = resto % 30;

            
            Console.WriteLine(N + " dias correspondem a:");
            Console.WriteLine(ano + " ano (s)");
            Console.WriteLine(mes + " mes (es)");
            Console.WriteLine(dia + " dia (s)");

        }
    }
}