using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Soma(2, 3);
            int s2 = Calculator.Soma(6, 9);
            int s3 = Calculator.Soma(5, 5);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
        }
    }
}
/*
  Se nao usassemos o "params" aqui, para a entrada de valores de parametros para a chamada de funcao
Calculator.Soma, deveriamos instanciar o vetor de parametros e tmbm na classe, prever todas as possibilidades 
de variacoes de entrada de parametros. Ou seja, para 2 parametros uma funcao, para 3 outra e assim por diante.
 */