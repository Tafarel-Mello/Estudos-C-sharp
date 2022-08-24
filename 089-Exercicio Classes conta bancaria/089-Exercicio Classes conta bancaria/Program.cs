using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroConta;
            string nomeTitular;
            char depositoInicial;
            float saldoInicial, saldo;

            Console.WriteLine("Entre o numero da conta: ");
            numeroConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre o titular da conta: ");
            nomeTitular = Console.ReadLine();

            Console.WriteLine("Havera deposito inicial (s/n)? ");
            depositoInicial = char.Parse(Console.ReadLine());

            Console.WriteLine("Entre o valor de deposito inicial: ");
            saldoInicial = float.Parse(Console.ReadLine());



        }
    }
}