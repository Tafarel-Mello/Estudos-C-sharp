using System;

class Program {
  public static void Main (string[] args) 
  {
    int positivos = 0; // contador de numeros positivos apenas
    int num;
    Console.Write("Digite um numero entre -100 e 100: ");
    num = int.Parse(Console.ReadLine());
    while (num >= -100 && num <= 100)
    {
      if(num >0)
        positivos = positivos + 1;
      Console.Write("Digite um numero entre -100 e 100: ");
      num = int.Parse(Console.ReadLine());
    }
    Console.Write($"Foram digitados {positivos} numeros positivos.");
  }
}