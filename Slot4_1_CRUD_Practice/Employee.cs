using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot4_1_CRUD_Practice
{
    internal class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateOnly Dob { get; set; }
        public bool Male { get; set; }

        public Employee()
        {
        }

        public Employee(int id, string fullName, DateOnly dob, bool male)
        {
            Id = id;
            FullName = fullName;
            Dob = dob;
            Male = male;
        }

        public void Input()
        {
            Console.Write("Nhập Id: ");
            Id = int.Parse(Console.ReadLine());
            Console.Write("Nhập FullName: ");
            FullName = Console.ReadLine();
            Console.Write("Nhập ngày sinh: ");
            Dob = DateOnly.Parse(Console.ReadLine());
            Console.Write("Nhập giới tính (true) or (false): ");
            Male = bool.Parse(Console.ReadLine());
        }


        public override string ToString()
        {
            string gender = Male == true ? "Male": "Female";
            return $"Id: {Id} - FullName: {FullName} - Dob: {Dob} - Gender: {gender}";
        }
    }
}
