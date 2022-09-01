using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            // o sinal "?" diz para a variavel que ela pode receber null
            double? x = null;
            double? y = 10;

            // o sinal "??" tem uma funcao de "if/else"
            // para "a" se "x" tiver um valor, sera atribuido o valor de "x"
            // mas se o "x" for nulo, "a" vai receber o valor "5" ---> double a = valor de x ??(se nulo) valor definido

            double a = x ?? 5; 
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
