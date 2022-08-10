using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1, pessoa2;

            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();


            Console.WriteLine("Digite seu nome: ");
            pessoa1.A = Console.ReadLine();

            Console.WriteLine("Agora digite sua idade: ");
            pessoa1.B = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite seu nome: ");
            pessoa2.A = Console.ReadLine();

            Console.WriteLine("Agora digite sua idade: ");
            pessoa2.B = int.Parse(Console.ReadLine());


            if( pessoa1.B > pessoa2.B )
            {
                Console.WriteLine("Pessoa mais velha: " + pessoa1.A);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + pessoa2.B);
            }
        }
    }
}

