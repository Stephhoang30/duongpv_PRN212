using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot2
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public Course()
        {
        }

        public Course(int id, string name, string code)
        {
            Id = id;
            Name = name;
            Code = code;
        }

        public virtual void Input()
        {
            Console.Write("Nhap IDCourse: ");
            Id = int.Parse(Console.ReadLine());
            Console.Write("Nhap NameCourse: ");
            Name = Console.ReadLine();
            Console.Write("Nhap CodeCourse: ");
            Code = Console.ReadLine();
        }

        public virtual void Display()
        {
            Console.WriteLine($"IdC: {Id} - NameC: {Name} - CodeC: {Code}");
        }
    }
}
