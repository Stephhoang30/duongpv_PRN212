using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Subject()
        {
        }

        public Subject(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"Id: {Id} - Name: {Name}";
        }
    }
}
