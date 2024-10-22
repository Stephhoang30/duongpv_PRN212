using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEvent
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }

        public Student()
        {
        }
        public Student(int id, string name, DateTime dob)
        {
            Id = id;
            Name = name;
            Dob = dob;
        }
    }
}
