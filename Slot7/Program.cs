namespace Slot7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoBasicDelegate();
        }

        public static void DemoBasicDelegate()
        {
            //CalculateFunction delegateObject; // khai báo biến

            //delegateObject = new CalculateFunction(Add); // khởi tạo đối tượng

            //Console.WriteLine(delegateObject(5, 7));

            //delegateObject = Sub;

            //Console.WriteLine(delegateObject(10, 5));

            Calculate(5, 7, Add);

            DemoMultiDelegate();

        }

        public static int Add(int x, int y)
        {
            Console.WriteLine("Add function");
            return x + y;
        }

        public static int Sub(int x, int y)
        {
            Console.WriteLine("Sub function");
            return x - y;
        }

        public static void Calculate(int x, int y, CalculateFunction delegateObject) 
        {
            Console.WriteLine(delegateObject(x, y));
        }

        public static void DemoMultiDelegate()
        {
            CalculateFunction delegateObject;
            delegateObject = Add;
            delegateObject += Sub;
            delegateObject += Add;
            Console.WriteLine(delegateObject(5,7));
        }
    }
}
