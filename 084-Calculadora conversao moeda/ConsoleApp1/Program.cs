using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual e a cotacao do dolar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dolares voce deseja comprar? ");
            double comprar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorFinal = Calculadora.Converte(cotacao, comprar); // chama o metodo fornecendo os parametros

            Console.WriteLine("Valor final a ser pago em reais: " + valorFinal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
