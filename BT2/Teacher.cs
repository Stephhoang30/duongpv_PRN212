using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    internal class Teacher
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateOnly Dob { get; set; }


        public Teacher(int id, string fullName, DateOnly dob)
        {
            Id = id;
            FullName = fullName;
            Dob = dob;
        }

        public Teacher() { }


        public virtual void Input()
        {
            Console.Write("Enter ID: ");
            Id = int.Parse(Console.ReadLine());

            Console.Write("Enter Full Name: ");
            FullName = Console.ReadLine();

            Console.Write("Enter Date of Birth: ");
            Dob = DateOnly.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"ID: {Id}, Full Name: {FullName}, Date of Birth: {Dob}";
        }
    }
}
