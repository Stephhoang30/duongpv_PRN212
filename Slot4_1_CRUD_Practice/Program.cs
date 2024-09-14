namespace Slot4_1_CRUD_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Department d = new Department(001, "IT Department");

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("=========Menu=========");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Remove Employee");
                Console.WriteLine("3. Update Employee");
                Console.WriteLine("4. ToString() ");
                Console.WriteLine("5. Show All");
                Console.WriteLine("0. Exit");
                Console.WriteLine("======================");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Employee e = new Employee();
                        e.Input();
                        double salary = d.addSalary();
                        d.AddEmployeeToDepartment(e, salary);
                        break;
                    case 2:
                        Console.Write("Nhập Id cần xóa: ");
                        int idToRemove = int.Parse(Console.ReadLine());
                        d.RemoveEmployeeToDepartment(idToRemove);
                        break;
                    case 3:

                        // nhap vao id can nhap nhat
                        Console.Write("Nhập vào Id cần cập nhật: ");
                        int idToUpdate = int.Parse(Console.ReadLine());

                        // gan id do cho doi tuong moi
                        Employee updateE = new Employee();
                        updateE.Id = idToUpdate;

                        // them thong tin cho doi tuong moi do
                        Console.WriteLine("Nhập vào thông tin chi tiết:");
                        Console.Write("Nhập tên: ");
                        updateE.FullName = Console.ReadLine();
                        Console.Write("Nhập ngày sinh: ");
                        updateE.Dob = DateOnly.Parse(Console.ReadLine());
                        Console.Write("Nhập giới tính: ");
                        updateE.Male = bool.Parse(Console.ReadLine());

                        // truyen doi tuong vao ham update de update vao dictionary
                        d.UpdateEmployeeToDepartment(updateE);
                        break;

                    case 4:
                        Console.WriteLine(d.ToString());                       
                        break;
                    case 5:
                        double salaryCheck = d.addSalary();
                        d.ShowAll(salaryCheck);
                        break;
                    case 0:
                        Console.WriteLine("Thoát chương trình!");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice. Try Again!");
                        break;

                }
            }
        }

    }
}
