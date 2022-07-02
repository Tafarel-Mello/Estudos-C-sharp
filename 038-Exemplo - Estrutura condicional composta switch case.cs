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

            switch (x)
            {
                case 1:
                    dia = "domingo";
                    break;
                case 2:
                    dia = "segunda";
                    break;
                case 3:
                    dia = "terca";
                    break;
                case 4:
                    dia = "quarta";
                    break;
                case 5:
                    dia = "quinta";
                    break;
                case 6:
                    dia = "sexta";
                    break;
                case 7:
                    dia = "sabado";
                    break;
                default:
                    dia = "valor invalido";
                    break;
            }

            Console.WriteLine("Dia da semana: " + dia);
            Console.ReadLine();


        }
    }
}