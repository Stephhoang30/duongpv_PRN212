using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot4._1
{
    internal class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateOnly Dob { get; set; }
        public bool Male { get; set; }

        public Employee(int id, string fullName, DateOnly dob, bool male)
        {
            Id = id;
            FullName = fullName;
            Dob = dob;
            Male = male;
        }

        public override string ToString()
        {
            string gender = Male ? "Male" : "Female";
            return $"Id: {Id} – FullName: {FullName} – Dob: {Dob.ToString("dd/MM/yyyy")} - Gender: {gender}";
        }
    }
}
