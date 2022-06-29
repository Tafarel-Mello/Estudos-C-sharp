using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int numeroFuncionario, horasTrab;
            double salario, salarioFinal;

            Console.WriteLine("Digite o nome do funcionario: ");
            nome = Console.ReadLine();

            Console.WriteLine($"Digite o numero do funcionario {nomeFuncionario}: ");
            numeroFuncionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero de horas trabalhadas: ");
            horasTrab = int.Parse(Console.ReadLine());  

            Console.WriteLine($"Digite o valor hora referente ao funcionario {nomeFuncionario}");
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            
            salarioFinal = horasTrab * salario;

            Console.WriteLine("NUMBER = " + numeroFuncionario);
            Console.WriteLine("SALARY = U$ " + salarioFinal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}