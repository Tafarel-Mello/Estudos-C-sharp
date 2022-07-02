using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int x; // numero relativo ao dia da semana
            string dia;

            x = int.Parse(Console.ReadLine());

            if (x == 1)
            {
                dia = "domingo";
            }
            else if (x == 2)
            {
                dia = "segunda";
            }
            else if (x == 3)
            {
                dia = "terca";
            }
            else if (x == 4)
            {
                dia = "quarta";
            }
            else if (x == 5)
            {
                dia = "quinta";
            }
            else if (x == 6)
            {
                dia = "sexta";
            }
            else if (x == 7)
            {
                dia = "sabado";
            }
            else
            {
                dia = "valor invalido";
            }

            Console.WriteLine("Dia da semana: " + dia);
            Console.ReadLine();


        }
    }
}