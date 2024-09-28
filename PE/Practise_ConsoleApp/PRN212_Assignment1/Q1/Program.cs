namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Requirement 1:");
            Console.WriteLine("You have entered:");
            var subject1 = new Subject(1, "Mathematics");
            Console.WriteLine(subject1);


            Console.WriteLine();
            Console.WriteLine("Requirement 2:");
            var course1 = new Course(101, "Engineering", new DateTime(2024, 9, 1));
            var subject2 = new Subject(2, "Physics");
            var subject3 = new Subject(3, "Chemistry");
            course1.AddSubject(subject2, 3);
            course1.AddSubject(subject3, 4);
            Console.WriteLine(course1.PrintCourseInfo());


            Console.WriteLine();
            Console.WriteLine("Requirement 3:");
            var subjectCheck = new Subject(2, "Physics");
            bool check = course1.ContainsSubject(subjectCheck);
            if (check) {
                Console.WriteLine("Belong to");
            }
            else
            {
                Console.WriteLine("Not Belong to");
            }

            Console.WriteLine();
            Console.WriteLine("Requirement 4:");


            // Sắp xếp danh sách các Course theo Name
            var course2 = new Course(101, "AI", new DateTime(2023, 9, 1));
            var courses = new List<Course> { course1, course2 };
            courses.Sort();
            foreach (var c in courses)
            {
                Console.WriteLine(c.PrintCourseInfo());

            }
        }
    }
}
