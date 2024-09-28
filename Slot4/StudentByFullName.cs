using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot4
{
    internal class StudentByFullName : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            return x.FullName.CompareTo(y.FullName);
        }
    }
}
