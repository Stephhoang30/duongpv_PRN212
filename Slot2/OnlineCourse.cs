using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot2
{
    internal class OnlineCourse
    {
        public string Url { get; set; }

        public OnlineCourse()
        {
        }

        public OnlineCourse(int id, string name, string code, string url) : base(id, name, code)
        {
            Url = url;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap URL: ");
            Url = Console.ReadLine();
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($" - URL: {Url}");

        }
    }
}
