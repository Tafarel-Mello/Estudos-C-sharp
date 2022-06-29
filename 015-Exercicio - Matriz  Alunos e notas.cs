using System;

class Program {
  public static void Main (string[] args) {

    int[,] Notas = new int[5,3];                           // 5 alunos e 3 notas cada

    for(int i = 0; i < 5; i++)
    {
      Console.Write($"\nAluno {i +1}\n");                  // entrada do aluno
      for(int j = 0; j < 3; j++)                           // entrada das notas do aluno "i"
      {
        Console.WriteLine($"Nota da prova {j + 1}: ");
        Notas[i,j] = int.Parse(Console.ReadLine());        // grava o aluno e a nota na prova "j"
      }
    }

    int Soma = 0;
    Double mediaAluno = 0;


    for(int i = 0; i < 5; i++)
    {
      Soma = 0;
      for(int j = 0; j < 3; j++)
      {
        Soma = Soma + Notas[i,j];                          // soma as notas do aluno "i" 
        mediaAluno = Soma / 3.0;                           // faz a media do aluno "i"
      }

      Console.WriteLine($"A soma das notas do aluno {i + 1} foi: {Soma}");
      Console.WriteLine($"A media final do aluno {i + 1} foi: {mediaAluno:0.0}");
      Console.WriteLine($"\n");
    }
  }
}