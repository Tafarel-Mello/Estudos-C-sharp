using System;
namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string day;

            switch (x)
            {
                case 1:
                    day = "Domingo";
                    break;
                case 2:
                    day = "Segunda-Feira";
                    break;
                case 3:
                    day = "Terca-Feira";
                    break;
                case 4:
                    day = "Quarta-Feira";
                    break;
                case 5:
                    day = "Quinta-Feira";
                    break;
                case 6:
                    day = "Sexta-Feira";
                    break;
                case 7:
                    day = "Sabado";
                    break;
                default:
                    day = "Numero invalido";
                    break;
            }

            Console.WriteLine("Dia: " + day);
        }
    }
}
