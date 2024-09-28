using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_SU24
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Dob {  get; set; }
        public string Major {  get; set; }

        public Student() { }
        public Student(int id, string name, DateTime dob, string major)
        {
            Id = id;
            Name = name;
            Dob = dob;
            Major = major;
        }

        public override string ToString()
        {
            return $"Student: {Id} - {Name} - {Dob.ToString("MM/dd/yyyy")} - {Major}";
        } 

    }

    public delegate void Presentation<T>(T item);

    class Group<T> 
    {
        public string Name { get; set; }
        
        private List<T> list = new List<T>();
        
        public Group() { }

        public Group(string name)
        {
            Name = name;
        }

        public void Add(T item)
        {
            list.Add(item);
        } 

        public void Remove(T item)
        {
            var rs = list.FirstOrDefault(
                i => i is Student s
                && item is Student s1
                && s.Id == s1.Id);
            list.Remove(rs);

            //var rs = list.FirstOrDefault(s => s.Equals(item));
            //list.Remove(rs);
        }

        public void Show(Presentation<T> presentation)
        {
            Console.WriteLine($"Group {Name} has {list.Count} students. List of students:");
            foreach(T item in list)
            {
                presentation(item);
            }
        }
    }

}
