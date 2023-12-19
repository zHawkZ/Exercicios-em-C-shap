using FirstProject.Entities;
using FirstProject.Entities.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;



namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker;
            string name, deptName;
            Departament departament;
            WorkerLevel level;
            double baseSalary, value;
            int nContracts, hours;         
            DateTime date;



            Console.Write("Enter departament's name: ");
            deptName = Console.ReadLine();
            Console.WriteLine("Enter woker data: ");
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            baseSalary = double.Parse(Console.ReadLine());
            Console.Write("How many contracts to this worker: ");
            nContracts = int.Parse(Console.ReadLine());
           
            departament = new Departament(deptName);
            worker = new Worker(name, level, baseSalary, departament);

            for (int i = 0; i < nContracts; i++)
            {
                Console.WriteLine($"Enter #{i + 1} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                value = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");
                hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(value, hours, date);
                worker.addContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name : " + worker.Name);
            Console.WriteLine("Department: " + worker.Departament.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.income(year, month).ToString("F2", CultureInfo.InvariantCulture));

        }
    }

}