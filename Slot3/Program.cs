using Slot3;

namespace Slot3
{
    internal class Program
    {
        static List<Course> courseList = new List<Course>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int choice;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1: Thêm 1 Course mới");
                Console.WriteLine("2: Xóa 1 Course");
                Console.WriteLine("3: Hiển thị tất cả các Course");
                Console.WriteLine("0: Thoát");
                Console.Write("Lựa chọn: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddCourse();
                        break;
                    case 2:
                        RemoveCourse();
                        break;
                    case 3:
                        DisplayAllCourses();
                        break;
                    case 0:
                        Console.WriteLine("Thoát chương trình.");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }

            } while (choice != 0);
        }

        // Hàm thêm khóa học
        static void AddCourse()
        {
            Console.WriteLine("Chọn loại Course: (C) Course thường, (O) OnlineCourse");
            string courseType = Console.ReadLine().ToUpper();
            Course course;

            if (courseType == "C")
            {
                course = new Course();
            }
            else if (courseType == "O")
            {
                course = new OnlineCourse();
            }
            else
            {
                Console.WriteLine("Lựa chọn không hợp lệ! Vui lòng chọn 'C' hoặc 'O'.");
                return;  
            }

            course.Input();
            courseList.Add(course);
            Console.WriteLine("Đã thêm Course thành công!");
        }


        // Hàm xóa khóa học
        static void RemoveCourse()
        {
            Console.Write("Nhập ID Course cần xóa: ");
            int id = int.Parse(Console.ReadLine());

            var cDelete = courseList.FirstOrDefault(c => c.Id == id);

            courseList.Remove(cDelete);

            //var cDelete = courseList.Where(c => c.Id == id).ToList();

            //courseList.Remove(cDelete[0]);        

            //Course courseToRemove = null;

            //foreach (Course course in courseList)
            //{
            //    if (course.Id == id)
            //    {
            //        courseToRemove = course;
            //        break;
            //    }
            //}

            //if (courseToRemove != null)
            //{
            //    courseList.Remove(courseToRemove);
            //    Console.WriteLine("Đã xóa Course thành công!");
            //}
            //else
            //{
            //    Console.WriteLine("Không tìm thấy Course với ID này.");
            //}
        }

        // Hàm hiển thị tất cả các khóa học
        static void DisplayAllCourses()
        {
            if (courseList.Count == 0)
            {
                Console.WriteLine("Không có Course nào trong danh sách.");
            }
            else
            {
                Console.WriteLine("Danh sách các Courses:");
                foreach (var course in courseList)
                {
                    Console.WriteLine(course.ToString());
                }
            }
        }
    }
}
