using System;

class Program {
  public static void Main (string[] args) 
  {

    string [,] Cadastro = new string[5,2];

    for(int i = 0; i < 5; i++)
    {
      Console.Write($"Nome do funcionario {i+1}: ");
      Cadastro[i,0] = Console.ReadLine(); 
      Console.Write($"Telefone do funcionario: ");
      Cadastro[i,1] = Console.ReadLine();
      
    }

    string Nome;
    bool Achou = false;

    Console.Write("\n\nDigite o nome do fundionario: ");
    Nome = Console.ReadLine();

    for(int i = 0; i < 5; i++)
    {
      if(Cadastro[i,0] == Nome)
      {
        Achou = true;
        Console.WriteLine($"O telefone do funcionario {Nome} e o numero {Cadastro[i,1]} !");
      }
    }
    if(!Achou)
      Console.WriteLine("Funcionario nao cadastrado");

    Console.ReadKey();
  }
}