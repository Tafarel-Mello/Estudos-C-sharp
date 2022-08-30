using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null; // para declarar uma variavel double com valor null
            double? y = 10.0; // variavel double que pode ser null em algum momento

            Console.WriteLine(x.GetValueOrDefault()); // mostra o valor atribuido ou o valor padrao caso nao tenha valor atribuido
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue); // operador logico que diz se existe valor dentro da variavel
            Console.WriteLine(y.HasValue);

            // Console.WriteLine(x.Value); // ela mostra o valor do objeto, tentar usar direto desta forma vai dar erro
            // Console.WriteLine(y.Value);

            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X is null");

            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y is null");

            /*
             desta forma, testamos se o "X" e o "Y" possuem valor assossiado
             se nao tiver, imprime a mensagem NULL, se nao, retorna o valor contido
             */



        }
    }
}
