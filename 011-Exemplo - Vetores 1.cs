using System;

class Program 
{
  static void Main(string[] args) 
  {
    int[] Vetor = new int[5]; // Declaracao do vetor

    // Entrada de elementos do vetor

      for (int i = 0; i < 5; i++)
      {
        Console.Write($"Digite o {i + 1}o elemento do vetor: ");
        Vetor[i] = int.Parse(Console.ReadLine());
      }

    // variaveis para s Soma e para a Quantidade

    int Soma;
    int Qtde;

    Soma = SomaPares(Vetor);
    Qtde = ContaImpares(Vetor);

    // Mostrando os resultados

    Console.WriteLine();

    Console.WriteLine($"Soma dos numeros pares: {Soma}");
    Console.WriteLine($"A quantidade de numeros impares: {Qtde}");
    
  }

    // funcoes

    static int SomaPares(int[] V)
    {
      int S = 0;                    // Variavel para somar os pares
  
      for (int i = 0; i < 5; i++)   // Para cada elemento do vetor
      {
        if (V[i] % 2 == 0)          // ele e par? a diviao do valor V no Indice i divido por 2 tem resto igual a zero?
          S += V[i];                // se sim, entao ele acumula
      }
  
      return S;                     // Retorna a soma
    }

    static int ContaImpares(int[] V)
    {
      int Q = 0;                    // Variavel para contar os impares
  
      for (int i = 0; i < V.Length; i++) // Para cada elemento do vetor
      {
        if (V[i] % 2 != 0)          // Ele e impar? Se o resto da divisao for diferente de zero    
          Q++;                      // Entao ele soma no contador
      }
  
      return Q;
    }
}