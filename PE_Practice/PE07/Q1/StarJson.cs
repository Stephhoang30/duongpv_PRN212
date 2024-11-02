using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class StarJson
    {
        public string FullName { get; set; }
        public bool Male { get; set; }
        public DateTime Dob {  get; set; }
        public string Description { get; set; }
        public string Nationality { get; set; }

        public StarJson()
        {
        }

        public StarJson(string fullName, bool male, DateTime dob, string description, string nationality)
        {
            FullName = fullName;
            Male = male;
            Dob = dob;
            Description = description;
            Nationality = nationality;
        }
    }
}
