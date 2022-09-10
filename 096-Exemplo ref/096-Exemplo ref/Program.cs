using System;
using System.Globalization;


namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            Calculator.Triple(ref a);
            Console.WriteLine(a);
        }
    }

    /*
     * Sem a utilizacao do comando "ref" a classe "Calculator" faria o calculo mas nao faria
     * a alteracao desejada na variavel no escopo principal do programa. O comando "ref" torna
     * a funcao "Calculator.Triple" uma referencia para a variavel passada como parametro, fazendo
     * assim a acao desejada.
     */
}