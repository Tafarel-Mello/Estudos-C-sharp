using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {


            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "TV 4K"; // via metodo "set" posso mudar o nome do atributo privado

            Console.WriteLine(p.Nome); // para acessar o atributo, so pelo metodo "get"
            Console.WriteLine(p.Preco);


        }
    }
}



