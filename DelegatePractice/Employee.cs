using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Position { get; set; }

        public delegate double SalaryCalculation (double Salary, string Position);
        public Employee()
        {
        }

        public Employee(int id, string name, double salary, string position)
        {
            Id = id;
            Name = name;
            Salary = salary;
            Position = position;
        }

        public void Input()
        {
            Console.Write("ID: ");
            Id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Salary: ");
            Salary = double.Parse(Console.ReadLine());
            Console.Write("Position: ");
            Position = Console.ReadLine().Trim();
        }

        public string Display(SalaryCalculation delObj)
        {
            return $"ID: {Id} - Name: {Name} - SalaryPerYear: {delObj(Salary, Position)} - Postion: {Position}";
        }

        public double SalCal(double Salary, string Position)
        {
            Position.ToLower();
            double salByYear = 0;
            if (Position == "manager")
            {
                salByYear = Salary * 16;
            }
            else if (Position == "developer")
            {
                salByYear = Salary * 14;
            }
            else if (Position == "tester")
            {
                salByYear = Salary * 12;
            }

            return salByYear;
        }

    }
}
