using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
    class Employee
    {
        // ******* atributos
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        // ******* Construtor
        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        // ******** Metodo
        public void IncreaseSalary(double percentual)
        {
            Salary = Salary + (Salary * (percentual / 100));
        }

        // ******** Override tostring
        public override string ToString()
        {
            return Id +
                ", " + 
                Name +
                ", " +
                Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

    }

}
