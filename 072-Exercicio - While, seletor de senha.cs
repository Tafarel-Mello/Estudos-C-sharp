using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = 2002;

            Console.WriteLine("Digite sua senha: ");
            int senha2 = int.Parse(Console.ReadLine());

            while (senha2 != senha)
            {
                Console.WriteLine("Senha invalida!");
                Console.WriteLine("Digite sua senha novamente: ");
                senha2 = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }

    }
}
