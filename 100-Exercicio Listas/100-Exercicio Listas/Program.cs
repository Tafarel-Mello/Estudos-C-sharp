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

            Console.WriteLine("Updated list of employees:");
            foreach(Employee emp in list)
            {
                Console.WriteLine(emp);
            }





            Console.ReadKey();
        }
    }
}
