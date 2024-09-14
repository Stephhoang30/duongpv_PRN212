namespace Slot4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emp1 = new Employee(1, "Nguyen Van A", new DateOnly(2021, 01, 01), true);
            var emp2 = new Employee(2, "Le Thi B", new DateOnly(1995, 05, 12), false);

            var department = new Department(1, "IT Department");
            department.AddEmployeeToDepartment(emp1, 3500000);
            department.AddEmployeeToDepartment(emp2, 2800000);

            
        }
    }
}
