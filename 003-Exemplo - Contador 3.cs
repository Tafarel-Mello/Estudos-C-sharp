using System;

class Program 
{
  public static void Main (string[] args) 
  {
    // Contador de numeros pares e impares, fazendo diferenciacao apos
    int pares = 0, impares = 0;
    int num;

    Console.Write("Digite um numero positivo: ");
    num = int.Parse(Console.ReadLine());
    while (num >= 0)
    {
      if (num % 2 == 0)
        pares = pares + 1;
      else
        impares = impares + 1;
      Console.Write("Digite um numero positivo: ");
      num = int.Parse(Console.ReadLine());
    }
    Console.Write($"Foram digitados {pares} numeros pares e {impares} numeros impares.");
  }
}