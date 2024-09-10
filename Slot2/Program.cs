namespace Slot2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Id = 1;
            s.Code = "HE172214";
            s.Dob = DateOnly.Parse("08-24-2003");

            Console.WriteLine($"ID: {s.Id} - Code: {s.Code} - Dob: {s.Dob}");

            //Course c = new Course();
            //c.Input();
            //c.Display();

            OnlineCourse oc = new OnlineCourse();
            oc.Input();
            oc.Display();
        }
    }
}
