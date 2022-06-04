using System;

class Program {
  public static void Main (string[] args) 
  {
    Double numero, raiz;

    Console.Write("Digite um numero: ");
    numero = Double.Parse(Console.ReadLine());
    while (numero > 0)
    {
      raiz = Math.Sqrt(numero);
      Console.WriteLine($"A raiz quadrada de {numero} = {raiz}");
      Console.Write("Digite outro numero: ");
      numero = Double.Parse(Console.ReadLine());
    }
    Console.Write("Raiz invalida.");
  }
}