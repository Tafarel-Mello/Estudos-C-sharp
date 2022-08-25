using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Digite o numero da nova conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Havera deposito inicial? (s/n): ");
            char resp = char.Parse(Console.ReadLine());

            if(resp == 's'|| resp == 'S')
            {
                Console.Write("Entre o valor a ser depositado: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, nome, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, nome);
            }

            Console.WriteLine();
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Deseja fazer outra operacao? 1-Deposito, 2-Saque, 3-Sair: ");
            int resp2 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            while(resp2 > 0 && resp2 < 3)
            {
                if(resp2 == 1)
                {
                    Console.Write("Entre o valor a ser depositado: ");
                    double quantia = double.Parse(Console.ReadLine());
                    conta.Deposito(quantia);
                    Console.WriteLine();
                    Console.WriteLine("Dados da conta atualizados: ");
                    Console.WriteLine(conta);
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("Entre o valor a ser sacado: ");
                    double quantia = double.Parse(Console.ReadLine());
                    conta.Saque(quantia);
                    Console.WriteLine();
                    Console.WriteLine("Dados da conta atualizados: ");
                    Console.WriteLine(conta);
                    Console.WriteLine();
                }

                Console.Write("Deseja fazer outra operacao? 1-Deposito, 2-Saque, 3-Sair: ");
                resp2 = int.Parse(Console.ReadLine());

            }

            Console.WriteLine();
            Console.WriteLine("Muito obrigado "+ conta.Nome + ", por fazer negocios conosco!");
            Console.ReadLine();


        }
    }
}
