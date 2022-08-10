using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int Alcool, Gasolina, Diesel;
            int tipo;

            Alcool = 0;
            Gasolina = 0;
            Diesel = 0;

            Console.WriteLine("Digite o codigo do seu combustivel: ");
            Console.WriteLine("1 - Alcool;");
            Console.WriteLine("2 - Gasolina;");
            Console.WriteLine("3 - Diesel.");

            tipo = int.Parse(Console.ReadLine());

            while (tipo != 4)
            {
                if (tipo == 1)
                {
                    Alcool = Alcool + 1;
                } else if (tipo == 2)
                {
                    Gasolina = Gasolina + 1;
                } else if (tipo == 3)
                {
                    Diesel = Diesel + 1;
                }

                Console.WriteLine("Digite o codigo do seu combustivel: ");
                Console.WriteLine("1 - Alcool;");
                Console.WriteLine("2 - Gasolina;");
                Console.WriteLine("3 - Diesel.");

                tipo = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Muito Obrigado!");
            Console.WriteLine("Alcool: " + Alcool);
            Console.WriteLine("Gasolina: " + Gasolina);
            Console.WriteLine("Diesel: " + Diesel);

        }
    }
}
