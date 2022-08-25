using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;


            Console.Write("Entre o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Havera deposito inicial (s/n)?: ");
            char resposta = char.Parse(Console.ReadLine());

            if(resposta == 's' || resposta == 'S')
            {
                Console.Write("Entre o valor do deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);  
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Deseja realisar outra operacao? 1-Deposito, 2-Saque ou 3-Finalizar: ");
            int resposta2 = int.Parse(Console.ReadLine());   

            while (resposta2 == 1 || resposta2 == 2)
            {

                if (resposta2 == 1)
                {
                    Console.Write("Entre um valor para deposito: ");
                    double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    conta.Deposito(quantia);
                    Console.WriteLine("Dados da conta atualizados: ");
                    Console.WriteLine(conta);
                }
                else
                {
                    Console.Write("Entre um valor para saque: ");
                    double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    conta.Saque(quantia);
                    Console.WriteLine("Dados da conta atualizados: ");
                    Console.WriteLine(conta);
                }

                Console.WriteLine();
                Console.Write("Deseja realisar outra operacao? 1-Deposito, 2-Saque ou 3-Finalizar: ");
                resposta2 = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }


            Console.ReadKey();

        }
    }
}