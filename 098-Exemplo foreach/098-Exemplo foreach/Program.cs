using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "Alex", "Bob" };


            // forma normal com comando for

            for(int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }

            Console.WriteLine("------------");

            // forma com comando foreach

            foreach(string nome in vect) // o "nome" tem a mesma funcao do "i" no for normal. Desta forma fica muito mais simples a declaracao do vetor 
            {
                Console.WriteLine(nome);
            }
        }
    }
}
