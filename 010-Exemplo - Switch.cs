using System;

class Program {
  public static void Main (string[] args) {
    int mes;
    Console.WriteLine("Digite o numero do mes: ");
    mes = int.Parse(Console.ReadLine());
    String mesStr;

    switch (mes)
    {
      case 1: mesStr = "Janeiro";
        break;
      case 2: mesStr = "Fevereiro";
        break;
      case 3: mesStr = "Marco";
        break;
      case 4: mesStr = "Abril";
        break;
      case 5: mesStr = "Maio";
        break;
      case 6: mesStr = "Junho";
        break;
      case 7: mesStr = "Julho";
        break;
      case 8: mesStr = "Agosto";
        break;
      case 9: mesStr = "Setembro";
        break;
      case 10: mesStr = "Outubro";
        break;
      case 11: mesStr = "Novembro";
        break;
      case 12: mesStr = "Dezembro";
        break;
      default: mesStr = "Mes invalido";;
        break;
    }
    Console.WriteLine(mesStr);
    switch (mesStr)
    {
      case "Janeiro":
      case "Marco":
      case "Maio":
      case "Julho":
      case "Agosto":
      case "Outubro":
      case "Dezembro":
        Console.WriteLine("Este mes tem 31 dias");
        break;
      case "Fevereiro":
        Console.WriteLine("Este mes tem 28 ou 29 dias");
        break;
      default:
        Console.WriteLine("Este mes tem 30 dias");
        break;
    }
  }
}