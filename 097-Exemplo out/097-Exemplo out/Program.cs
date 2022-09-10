using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10; // parametro de entrada - deve ser iniciada
            int triplo; // local onde o resultado sera instanciado - nao precisa ser iniciada

            Calculator.Triplo(a, out triplo);
            Console.WriteLine(triplo);
        }
    }
    /*
     * Com a funcao "out" temos quase o mesmo comportamento que no "ref"
     * com a diferenca que o resultado do metodo chamado em "Calculator.Triplo" sera salvo
     * em outra variavel, que nao precisa ser iniciada previamente, e nao na variavel original "a".
     */
}
