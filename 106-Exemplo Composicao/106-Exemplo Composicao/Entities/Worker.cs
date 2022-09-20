using System;
using System.Collections.Generic;
using _106_Exemplo_Composicao.Entities.Enums;

namespace _106_Exemplo_Composicao.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkrLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departement Departement { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {
        }

        public Worker(string name, WorkrLevel level, double baseSalary, Departement departement)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departement = departement;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach(HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
