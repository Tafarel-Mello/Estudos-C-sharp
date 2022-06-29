using System;

class Program 
{
  public static void Main (string[] args) {
    int num;
    int soma = 0; // acumulador

    Console.Write("Digite um numero maior que zero: ");
    num = int.Parse(Console.ReadLine());
    while (num > 0)
    {
      soma = soma + num;
      Console.Write("Digite um numero maior que zero: ");
      num = int.Parse(Console.ReadLine());
    }
    Console.Write($"A soma dos numeros digitados foi = {soma}");
  }
}