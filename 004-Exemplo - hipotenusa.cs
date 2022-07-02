using System;

class Program {
  public static void Main (string[] args) {

    // Declaracao das variaveis

    Double Cateto1, Cateto2;
    Double Hipotenusa;

    // Entrada de dados 
    Console.Write("Informe o valor do cateto 1: ");
    Cateto1 = int.Parse(Console.ReadLine());
    Console.Write("Informe o valor do cateto 2: ");
    Cateto2 = int.Parse(Console.ReadLine());

    // Calculos de processamento

    Hipotenusa = Math.Sqrt(Math.Pow(Cateto1,2) + Math.Pow(Cateto2,2));

    // Saida de dados

    Console.Write($"Hipotenusa = {Hipotenusa}");
    
  }
}