using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * sintaxe => (condicao) ? valor se verdadeiro : valor se for falso
             * alternativa para if/else
             */

            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double precoFinal;

            //double desconto;
            /*
            if(preco < 20.0)
            {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.05;
            }
            */

            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;





            precoFinal = preco - desconto;
            Console.WriteLine(preco);
        }
    }
}
