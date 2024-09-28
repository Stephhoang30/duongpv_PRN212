using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot4
{
    internal class Student : IComparable<Student>
    {
        public int Id { get; set; }
        public string StudentCode { get; set; }
        public string FullName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public double CPA { get; set; }

        public Student()
        {
        }

        public Student(int id, string studentCode, string fullName, DateOnly dateOfBirth, double cpa)
        {
            Id = id;
            StudentCode = studentCode;
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            CPA = cpa;
        }

        public override string ToString()
        {
            return $"Id: {Id} | Code: {StudentCode} | FullName: {FullName} | DOB: {DateOfBirth} | CPA: {CPA}";
        }

        public int CompareTo(Student? other)
        {
            return other.CPA.CompareTo(CPA);
        }

    }
}
