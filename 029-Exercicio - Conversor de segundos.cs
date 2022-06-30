using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, horas, restoHoras, minutos, restoMinutos, segundos;

            Console.WriteLine("Digite uma quantidade de segundos qualquer: ");
            N = int.Parse(Console.ReadLine());

            horas = N / 3600; // 3600 segundos em 1 hora
            restoHoras = N % 3600; // pega o resto da divisao para encontrar os minutos

            minutos = restoHoras / 60;
            restoMinutos = restoHoras % 60;

            segundos = restoMinutos;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);

        }
    }
}