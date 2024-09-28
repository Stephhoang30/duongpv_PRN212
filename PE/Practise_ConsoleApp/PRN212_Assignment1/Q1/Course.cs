using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Course : IComparable<Course>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime startDate { get; set; }

        private Dictionary<Subject, double> SubjectCredit = new Dictionary<Subject, double>();

        public Course()
        {
        }

        public Course(int id, string name, DateTime startDate)
        {
            Id = id;
            Name = name;
            this.startDate = startDate;
        }

        public void AddSubject(Subject s, double b)
        {
            SubjectCredit[s] = b;
        }

        public void RemoveSubject(Subject s)
        {
            var rs = SubjectCredit.FirstOrDefault(sc => sc.Key == s);
            SubjectCredit.Remove(rs.Key);
        }

        public bool ContainsSubject(Subject subject)
        {
            foreach (var sc in SubjectCredit)
            {
                if ((sc.Key.Id == subject.Id) && (sc.Key.Name.Equals(subject.Name)))
                {
                    return true;
                }
            } 
            return false;
        }

        public string PrintCourseInfo()
        {
            var rs = "";
            foreach (var c in SubjectCredit)
            {
                rs += $"\n- {c.Key.Name} ({c.Value} credits)";
            }
            return $"Course ID: {Id}, Course Name: {Name}, Start Date: {startDate.ToString("M/d/yyyy")}\nSubjects:{rs}";
        }

        public int CompareTo(Course? other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
