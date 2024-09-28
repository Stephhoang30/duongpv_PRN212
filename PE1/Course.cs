using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE1
{
    internal class Course
    {
        public int CourseID { get; set; }
        public string CourseTitle { get; set; }

        private Dictionary<Student, double> studentGrades = new Dictionary<Student, double>();

        public Course()
        {
        }

        public Course(int courseID, string courseTitle)
        {
            CourseID = courseID;
            CourseTitle = courseTitle;
        }

        public event Action<int, int> OnNumberOfStudentChange;

        public void AddStudent(Student p, double g)
        {
            int oldNumber = studentGrades.Count;
            studentGrades[p] = g;
            int newNumber = studentGrades.Count;
            OnNumberOfStudentChange?.Invoke(oldNumber, newNumber);
        }

        public void RemoveStudent(int StudentID)
        {

            var rs = studentGrades.FirstOrDefault(sg => sg.Key.StudentID == StudentID);
            if (rs.Key != null)
            {
                int oldNumber = studentGrades.Count;
                studentGrades.Remove(rs.Key);
                int newNumber = studentGrades.Count;
                OnNumberOfStudentChange?.Invoke(oldNumber,newNumber);
            }
        }

        public override string ToString()
        {
            string res = "";
            foreach (var sg in studentGrades)
            {
                res += $"\nStudent: {sg.Key.StudentID} - {sg.Key.StudentName} - Mark: {sg.Value}";
            }
            return $"Course: {CourseID} - {CourseTitle} {res}";

        }
    }
}
