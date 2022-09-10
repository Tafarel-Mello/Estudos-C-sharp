using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
    class Calculator
    {
        public static int Soma(params int[] numeros)
        {
            int soma = 0;
            for(int i = 0; i < numeros.Length; i++)
            {
                soma = soma + numeros[i];
            }
            return soma;
        }
    }
}

/*
 A instrucao "params" ja diz para funcao que os parametros podem variar
e o comando "for" vai criar o vetor em funcao dos parametros entrados para a funcao
desta forma nao se faz necessario instanciar um vetor com o "new" no programa principal
para chamar a funcao desejada
 */