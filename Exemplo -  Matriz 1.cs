using System;

class Program {
  public static void Main (string[] args) 
  {
    //    Exemplo de Matriz

    //            5  8  3  2  9
    //            9  0  1  4  2
    //            7  8  1  2  0
    //            6  2  6  9  1
    //            3  9  7  2  2

    // A diagonal principal da Matriz: 5  0  1  9  2

    int [,] Matriz = new int[5,5];        // Declaracao da matriz
    int[] VetorResultante = new int[5];   // Declaracao do vetor resultante

    for(int i = 0; i < 5; i++)           // Para cada linha da matriz
    {
      for(int j = 0; j < 5; j++)         // Para cada coluna da matriz 
      {
        Console.Write($"Elemento ({i+1},{j+1}): ");

        Matriz[i,j] = int.Parse(Console.ReadLine());  // Le o valor do elemento
      }
    }

    // Chamadas de funcoes
    // Envia a Matriz e recebe como resultado um vetor

    VetorResultante = ExtraiDiagPrinc(Matriz);

    // Agora mostrando

    Console.Write("\n\nDiagonal Principal: ");

    for(int i = 0; i < 5; i++)               // Para cada coluna da matriz
    {
      Console.Write($"{VetorResultante[i],7}");
    }

    Console.WriteLine("\n");

  }

  static int[] ExtraiDiagPrinc(int[,] M)
  {
    int[] Result = new int[5];

    for(int i = 0; i < 5; i++)            // Para cada linha da matriz
    {
      for(int j = 0; j < 5; j++)          // Para cada coluna da matriz
      {
        if (i == j)                       // Estamos na Diag. principal???
          Result[i] = M[i,j];             // se sim, alimentamos o valor
      }
    }

    return Result;
  }
}