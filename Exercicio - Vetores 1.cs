using System;

class Program 
{
  static void Main(string[] args) 
  {

    int[] vetorPrinc = new int [10];
    int maiorValor = 0; 
    int menorValor = 0; 
    int valor;
    int contaPares = 0; 
    int contaImpares = 0;
    int soma = 0;
    Double Media = 0;
    int contador = 1;
    

    while(contador <= 10)
    {
      Console.Write($"Digite o {contador}o numero: ");
      valor = int.Parse(Console.ReadLine());

      if(contador == 1)
      {
        maiorValor = valor;
        menorValor = valor;
      }
        if( valor > maiorValor )
          maiorValor = valor;
          else if( valor < menorValor )
            menorValor = valor;

      if(valor % 2 == 0)
        contaPares++;
      else
        contaImpares++;

      soma = soma + valor;


      contador++;
    }

    Media = soma / 10.0;

    
    Console.WriteLine($"\n");
    Console.WriteLine($"O maior numero digitado foi: {maiorValor}.");
    Console.WriteLine($"\n");
    Console.WriteLine($"O menor numero digitado foi: {menorValor}.");
    Console.WriteLine($"\n");
    Console.WriteLine($"Foram digitados {contaPares} numeros pares.");
    Console.WriteLine($"\n");
    Console.WriteLine($"Foram digitados {contaImpares} numeros impares.");
    Console.WriteLine($"\n");
    Console.WriteLine($"A soma dos numeros digitados foi: {soma}.");
    Console.WriteLine($"\n");
    Console.WriteLine($"A media dos numeros digitados foi: {Media}.");
    
  }
}