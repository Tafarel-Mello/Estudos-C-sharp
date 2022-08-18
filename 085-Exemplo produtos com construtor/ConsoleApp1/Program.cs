using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Entre os dados do produto: ");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preco: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade); // aqui ocorre a instanciacao do produto


            Console.WriteLine("Dados do produto: " + p);


            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte); // a quantidade entrada em 'qte' vai para a funcao AdicionarProdutos como parametro

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte); // a quantidade entrada em 'qte' vai para a funcao AdicionarProdutos como parametro

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            

        }
    }
}

