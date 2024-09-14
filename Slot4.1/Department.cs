using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot4._1
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private Dictionary<Employee, double> DepartmentEmployee = new();

        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddEmployeeToDepartment(Employee e, double salary)
        {
            if (!DepartmentEmployee.ContainsKey(e))
            {
                DepartmentEmployee[e] = salary;
            }
        }

        public void RemoveEmployeeFromDepartment(int employeeId)
        {
            Employee employeeToRemove = null;

            foreach (var employee in DepartmentEmployee.Keys)
            {
                if (employee.Id == employeeId)
                {
                    employeeToRemove = employee;
                    break;
                }
            }

            if (employeeToRemove != null)
            {
                DepartmentEmployee.Remove(employeeToRemove);
            }
        }

        public void UpdateEmployeeInDepartment(Employee e)
        {

        }


        public override string ToString()
        {
            string result = $"Department Id: {Id} - Name: {Name}\nEmployees:\n";
            foreach (var employee in DepartmentEmployee)
            {
                result += $"{employee.Key.ToString()} - Salary: {employee.Value}\n";
            }
            return result;
        }

        public void ShowAll(double salary)
        {
            foreach (var employee in DepartmentEmployee)
            {
                if (employee.Value > salary)
                {
                    Console.WriteLine($"{employee.Key.ToString()} - Salary: {employee.Value}");
                }
            }
        }

    }
}
