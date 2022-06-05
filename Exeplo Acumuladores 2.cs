using System;

class Program 
{
  public static void Main (string[] args) {
    Double preco, totalCompra = 0, totalTax = 0; // acumulador

    Console.Write("Digite o preco do produto ou ZERO para finalizar: ");
    preco = Double.Parse(Console.ReadLine());
    while (preco > 0)
    {
      totalCompra = totalCompra + preco;
      Console.Write($"\tSubtotal = R$ {totalCompra:0.00}.\n");
      totalTax = totalCompra + (totalCompra * 0.15);
      Console.Write($"\tSubtotal com taxas = R$ {totalTax:0.00}.\n");
      Console.Write("Digite o preco do produto ou ZERO para finalizar: ");
      preco = Double.Parse(Console.ReadLine());
    }
    Console.Write($"\nO valor total da sua compra foi = R$ {totalTax:0.00}");
  }
}