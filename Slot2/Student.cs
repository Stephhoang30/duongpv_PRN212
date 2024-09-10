using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot2
{
    internal class Student
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public DateOnly Dob { get; set; }

        public Student()
        {
        }

        public Student(int id, string code, DateOnly dob)
        {
            Id = id;
            Code = code;
            Dob = dob;
        }
    }
}
