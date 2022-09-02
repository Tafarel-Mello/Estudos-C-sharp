using System;
namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao pensionado do Mario!");
            Reserva[] vect = new Reserva[10];

            Console.WriteLine();
            Console.Write("Quantos quartos gostaria de alugar?: ");
            int qtd = int.Parse(Console.ReadLine());


            for (int i = 1; i <= qtd; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Quarto #{i}:");

                Console.Write("Nome do locatario: ");
                string nome = Console.ReadLine();
                Console.Write("Telefone do locatario: ");
                string telefone = Console.ReadLine();
                Console.Write("Contato de e-mail do locatario: ");
                string email = Console.ReadLine();
                Console.Write("Numero do quarto desejado? ");
                int quarto = int.Parse(Console.ReadLine());

                while (vect[quarto] != null)
                {
                    Console.Write("Quarto ocupado, por favor escolha outro: ");
                    quarto = int.Parse(Console.ReadLine());

                }
                vect[quarto] = new Reserva(nome, email, telefone);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for(int i = 1; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
