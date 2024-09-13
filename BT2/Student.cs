using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    internal class Student: Teacher
    {
        public double CPA { get; set; }

        public Student(int id, string fullName, DateOnly dob, double cpa)
            : base(id, fullName, dob)
        {
            CPA = cpa;
        }

        public Student() { }

        public override void Input()
        {
            base.Input();

            Console.Write("Enter CPA: ");
            CPA = double.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return base.ToString() + $", CPA: {CPA}";
        }
    }
}
