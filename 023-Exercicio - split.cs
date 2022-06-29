using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        public static void Main(string[] args)
        {
            string nome;
            int quartos;
            double precoProduto;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem sua casa: ");
            quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preco de um produto qualquer: ");
            precoProduto = double.Parse(Console.ReadLine());

            Console.WriteLine("Agora digite seu sobre-nome, sua idade e sua altura: ");
            string[] vet = Console.ReadLine().Split(' ');
            string ultimoNome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);

            Console.WriteLine("\nConfirme seu dados digitados");
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(precoProduto.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString(CultureInfo.InvariantCulture));


        }
    }
}
