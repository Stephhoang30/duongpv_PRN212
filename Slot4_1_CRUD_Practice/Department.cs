using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot4_1_CRUD_Practice
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private Dictionary<Employee, double> DepartmentEmployee = new Dictionary<Employee, double>();

        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddEmployeeToDepartment(Employee e, Double salary)
        {
            DepartmentEmployee[e] = salary;
            Console.WriteLine("Add DONE!");
        }

        public void RemoveEmployeeToDepartment(int EmployeeId)
        {
            Employee eToRemove = null;

            foreach (var e in DepartmentEmployee)
            {
                if(e.Key.Id == EmployeeId)
                {
                    eToRemove = e.Key;
                    break;
                }              
            }

            if (eToRemove != null)
            {
                DepartmentEmployee.Remove(eToRemove);
                Console.WriteLine("Remove DONE!");
            }
        }

        public override string ToString()
        {
            string result = "";
            foreach (var e in DepartmentEmployee)
            {
                result += $"EmployeeName: {e.Key.FullName} - Salary: {e.Value}\n";
            }
            return $"Id: {Id} - Name: {Name}\nEmployee:\n{result}";
        }

        public void ShowAll(double s)
        {
            Console.Write($"Employee has salary > {s}:\n");
            foreach (var e in DepartmentEmployee)
            {
                if (e.Value > s)
                {
                    Console.WriteLine($"EName: {e.Key.FullName} - Salary: {e.Value}\n");
                }
            }
        }
    }
}
