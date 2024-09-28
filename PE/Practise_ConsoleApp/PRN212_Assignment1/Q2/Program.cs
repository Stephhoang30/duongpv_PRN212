namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Requirement 1:");
            Student s = new Student(1, "Nguyen Van A", new DateOnly(1999, 10, 20), "Female");
            Console.WriteLine("You have entered:");
            Console.WriteLine(s);

            Console.WriteLine(Environment.NewLine + "---------------");
            Console.WriteLine("Requirement 2:");

            // Khởi tạo đối tượng c = Class<Student>("Accounting Class")
            // Add 3 đối tượng Student vào trong c với 3 đối tượng là 
            // new Student(2, "Nguyen Van B", new DateOnly(1999, 10, 20), "Female"
            // new Student(3, "Nguyen Van C", new DateOnly(1989, 11, 15), "Male")
            // new Student(4, "Nguyen Van D", new DateOnly(2000, 4, 2), "Male")
            // Gọi method c.Display(DisplaysFullInfoOfStudent);
            Class<Student> c = new Class<Student>("Accounting Class");
            c.Add(new Student(2, "Nguyen Van B", new DateOnly(1999, 10, 20), "Female"));
            c.Add(new Student(3, "Nguyen Van C", new DateOnly(1989, 11, 15), "Male"));
            c.Add(new Student(4, "Nguyen Van D", new DateOnly(2000, 4, 2), "Male"));
            c.Display(DisplaysFullInfoOfStudent);

            Console.WriteLine(Environment.NewLine + "---------------");
            Console.WriteLine("Requirement 3:");
            Student s1 = new Student(3, "Nguyen Van C", new DateOnly(1989, 11, 15), "Male");
            if (c.Contains(s1))
                Console.WriteLine("The student you are looking for belongs to the class");
            else Console.WriteLine("The student you are looking for does not belong to the class");

            Console.WriteLine(Environment.NewLine + "---------------");
            Console.WriteLine("Requirement 4:");
            c.Display(DisplaysBriefInfoOfStudnet);

        }
        private static void DisplaysFullInfoOfStudent(Student employee)
        {
            Console.WriteLine($"{employee.Id} - {employee.Name} - {employee.Dob.ToLongDateString()}");
        }
        private static void DisplaysBriefInfoOfStudnet(Student employee)
        {
            Console.WriteLine($"{employee.Id} - {employee.Name}");
        }


    }

}
