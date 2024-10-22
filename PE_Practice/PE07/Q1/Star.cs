using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Star
    {
        public string Name {  get; set; }
        public string Gender { get; set; }
        public DateOnly Dob {  get; set; }
        public string Nationality { get; set; }

        public Star()
        {
        }

        public Star(string name, string gender, DateOnly dob, string nationality)
        {
            Name = name;
            Gender = gender;
            Dob = dob;
            Nationality = nationality;
        }

    }
}
