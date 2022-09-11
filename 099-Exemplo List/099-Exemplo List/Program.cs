using System;
using System.Collections.Generic;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<string> lista = new List<string>(); // pode instanciar sem inicar
            // List<string> lista2 = new List<string> {"Maria", "jose"}; // pode instanciar e iniciar se desejado


            List<string> lista = new List<string>();

            lista.Add("Maria"); // posicao 0
            lista.Add("Alex"); // posicao 1
            lista.Add("Bob"); // posicao 2
            lista.Add("Anna"); // posicao 3

            lista.Insert(2, "Marco"); // sera inserido na posicao "2"

            foreach (string s in lista)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("List count: " + lista.Count);

            string s1 = lista.Find(x => x[0] == 'A'); // sintaxe lambda = x tal que x na posicao 0 eh igual a 'A'.

            Console.WriteLine("Primeiro 'A': " + s1);

            string s2 = lista.FindLast(x => x[0] == 'A'); // ultimo elemento da lista que corresponde ao predicado
            Console.WriteLine("Ultimo 'A': " + s2);

            int pos1 = lista.FindIndex(x => x[0] == 'A'); // encontra a posicao na lista do elemento
            Console.WriteLine("Primeira posicao 'A': " + pos1);

            int pos2 = lista.FindLastIndex(x => x[0] == 'A'); // encontra a posicao na lista do elemento
            Console.WriteLine("Ultima posicao 'A': " + pos2);

            //********************** Filtrar a lista *********************

            Console.WriteLine("-------------------");

            List<string> filtro = lista.FindAll(x => x.Length == 5); // filtra todos os elementos com tamanho 5
            foreach (string obj in filtro)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-------------------");

            lista.Remove("Alex");
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-------------------");

            lista.RemoveAll(x => x[0] == 'M');
            foreach(string obj in lista)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-------------------");



        }
    }
}

/*
 * A grande diferenca da Lista para o vetor sao:
 * A lista inicia vazia e vamos adicionando elementos.
 * A lista em relacao ao vetor, pode "ir recebendo" elementos sem precisar instanciar
 * no inicio onumero de posicoes desejadas.
 * Porem para acessar um elemento de lista, eh necessario percorer todos os elementos ate chegar no desejado
 * ao contrario do vetor que acessa direto o item desejado
 */