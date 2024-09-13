using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    internal class Program
    {
        static List<Teacher> teachers = new List<Teacher>();
        static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1: Add Teacher/Student");
                Console.WriteLine("2: Display All");
                Console.WriteLine("3: Display by Age");
                Console.WriteLine("4: Delete by ID");
                Console.WriteLine("0: Exit");
                Console.Write("Choose an option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddTeacherOrStudent();
                        break;
                    case 2:
                        DisplayAll();
                        break;
                    case 3:
                        DisplayByAge();
                        break;
                    case 4:
                        DeleteById();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        static void AddTeacherOrStudent()
        {
            while (true)
            {
                Console.WriteLine("T: Add Teacher");
                Console.WriteLine("S: Add Student");
                Console.Write("Choose an option (T/S): ");
                string type = Console.ReadLine().ToUpper();

                if (type == "T")
                {
                    Teacher teacher = new Teacher();
                    teacher.Input();
                    teachers.Add(teacher);
                    Console.WriteLine("Teacher added successfully.");
                    break;
                }
                else if (type == "S")
                {
                    Student student = new Student();
                    student.Input();
                    students.Add(student);
                    Console.WriteLine("Student added successfully.");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice!!!");
                }
            }
        }

        static void DisplayAll()
        {
            Console.WriteLine("Teachers:");
            foreach (var teacher in teachers)
            {
                Console.WriteLine(teacher);
            }

            Console.WriteLine("Students:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }


        static void DisplayByAge()
        {
            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());

            int currentYear = 2024;

            Console.WriteLine("Teachers:");
            foreach (var teacher in teachers)
            {
                int teacherAge = currentYear - teacher.Dob.Year;    
                
                if (teacherAge > age)
                {
                    Console.WriteLine(teacher);
                }
            }

            Console.WriteLine("Students:");
            foreach (var student in students)
            {
                int studentAge = currentYear - student.Dob.Year;

                if (studentAge > age)
                {
                    Console.WriteLine(student);
                }
            }
        }

        static void DeleteById()
        {
            Console.Write("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());

            bool found = false;

            foreach (var teacher in teachers.ToList()) 
            {
                if (teacher.Id == id)
                {
                    teachers.Remove(teacher);
                    Console.WriteLine("Teacher removed.");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                foreach (var student in students.ToList())
                {
                    if (student.Id == id)
                    {
                        students.Remove(student);
                        Console.WriteLine("Student removed.");
                        found = true;
                        break;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("ID not found.");
            }
        }

    }
}
