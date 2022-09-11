using System;
using System.Globalization;
using System.Collections.Generic;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>(); // instaciamento da lista

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Employee(id, name, salary)); // instanciamento do elemento "Employee"
                Console.WriteLine();
            }

            Console.Write("Enter the Employee id that will have salary increase : ");
            int procuraId = int.Parse(Console.ReadLine()); // variavel para armazenar o ID desejado

            Employee emp = list.Find(x => x.Id == procuraId); // variavel do tipo Employee que vai receber o resultado do processo list.Find para o processo de aumento de salario
            if(emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentual);
            }
            else
            {
                Console.WriteLine("This is does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach(Employee obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.ReadKey();
        }
    }
}
