using System;

class Program {
  public static void Main (string[] args) {
    // Declaracao das variaveis 
    int n1, n2, n3, n4, n5, Soma;
    Double Media;

    // Entrada de dados
    Console.Write("Digite o primeiro numero Inteiro: ");
    n1 = int.Parse(Console.ReadLine());
    Console.Write("Digite o segundo numero Inteiro: ");
    n2 = int.Parse(Console.ReadLine());
    Console.Write("Digite o terceiro numero Inteiro: ");
    n3 = int.Parse(Console.ReadLine());
    Console.Write("Digite o quarto numero Inteiro: ");
    n4 = int.Parse(Console.ReadLine());
    Console.Write("Digite o quinto numero Inteiro: ");
    n5 = int.Parse(Console.ReadLine());

    // Calculos / Processamento
    Soma = n1 + n2 + n3 + n4 + n5;
    Media = Soma / 5.0;

    // Saida de dados
    Console.WriteLine($"Soma = {Soma}");
    Console.WriteLine($"Media = {Media}");
  }
}