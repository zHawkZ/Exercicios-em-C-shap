using System;
using System.Collections.Generic;
using FirstProject.Entities.Enums;

namespace FirstProject.Entities
{
    internal class Worker
    {
        public string Name { get; set; }

        public WorkerLevel Level { get; set; }

        public double BaseSalary { get; set; }

        public Departament Departament { get; set; }

        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker() { }

        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void addContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void removeContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double income(int year, int mounth)
        {
            double sume = BaseSalary;

            foreach (HourContract contract in Contracts)
            {
                if (contract.Data.Year == year && contract.Data.Month == mounth)
                    sume += contract.TotalValue();
            }
            return sume;
        }

    }
}
