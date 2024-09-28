namespace DelegatePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Input();
            Console.WriteLine(e.Display(e.SalCal));
        }
        

    }
}
