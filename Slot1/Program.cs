namespace Slot1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ho va ten: ");
            string fullName = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            string yob = Console.ReadLine();
            int age = 2024 - int.Parse(yob);
            Console.WriteLine("================================");
            Console.WriteLine($"Ho va ten: {fullName}");
            Console.WriteLine($"Nam sinh: {age}");
        }
    }
}
