using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly Dob { get; set; }
        public string Gender { get; set; }
        public Student()
        {
        }

        public Student(int id, string name, DateOnly dob, string gender)
        {
            Id = id;
            Name = name;
            Dob = dob;
            Gender = gender;
        }

        public override string ToString() 
            => $"Id: {Id} - Name: {Name} - Dob: {Dob} - Gender: {Gender}";

        public delegate void Presentation<T>(T item);

    }

    class Class<T> where T : Student
    {
        public string Name { get; set; }

        private List<T> ls = new List<T>();

        // constructor
        public Class() { }

        public Class(string name)
        {
            Name = name;
        }
        
        // method
        public void Add(T item)
        {
            ls.Add(item);
        }

        public bool Contains(T item)
        {
            foreach(var e in ls)
            {
                if ((e.Id == item.Id) && (e.Name == item.Name)) return true;
            }
            return false;
        }

        public void Display(Student.Presentation<T> presentation)
        {
            Console.WriteLine($"{Name}: Student");
            foreach(var item in ls)
            {
                presentation(item);
            }
        }

    }
}
