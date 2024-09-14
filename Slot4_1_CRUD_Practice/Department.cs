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

        // Func to add employee
        public void AddEmployeeToDepartment(Employee e, Double salary)
        {
            DepartmentEmployee[e] = salary;
            Console.WriteLine("Add DONE!");
        }

        // Func to remove employee
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
            } else
            {
                Console.WriteLine("Employee not found!");
            }
        }

        // Func to update employee
        public void UpdateEmployeeToDepartment(Employee e)
        {
            Employee existEm = null;

            // lặp tim kiem employee co id can cap nhat
            // gan vao obj moi la existEm
            foreach (var ex in DepartmentEmployee)
            {
                if (ex.Key.Id == e.Id)
                {
                    existEm = ex.Key;
                    break;
                }
            }
      
            if (existEm != null)
            {
                // update thong tin
                existEm.FullName = e.FullName;
                existEm.Dob = e.Dob;
                existEm.Male = e.Male;
                DepartmentEmployee[existEm] = addSalary();

                Console.WriteLine("Update DONE!");

            } else
            {
                Console.WriteLine("Employee not found!");
            }
        }


        // Func to display info department and employee
        public override string ToString()
        {
            string result = "";
            foreach (var e in DepartmentEmployee)
            {
                result += $"Name: {e.Key.FullName} - Salary: {e.Value}\n";
            }
            return $"Id: {Id} - Name: {Name}\nEmployee:\n{result}";
        }

        // Func to display employee who has salary > salaryChecked
        public void ShowAll(double s)
        {
            foreach (var e in DepartmentEmployee)
            {
                if (e.Value > s)
                {
                    Console.WriteLine($"EName: {e.Key.FullName} - Salary: {e.Value}\n");
                }
            }
        }

        public Double addSalary()
        {
            Console.Write("Nhập vào mức lương: ");
            double salary = double.Parse(Console.ReadLine());
            return salary;
        }
    }
}
