using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_SU24_B5
{
    
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(int id, string name, string type, double price)
        {
            Id = id;
            Name = name;
            Type = type;
            Price = price;
        }

        public delegate double TaxCalculation(Product p); // nhan vao 1 doi tuong Product
                                                          // tra ve 1 gia tri double

        public void Display(TaxCalculation c) { // tham so truyen vao: 1 bieu thuc lambda       
            Console.WriteLine($"Product: Id: {Id} - Name: {Name} - Type: {Type} - Price: {Price} - Tax: {c(this)}");
        }
        public static double Display(List<Product> products, TaxCalculation c)
        {
            foreach (var p in products)
            {              
                Console.WriteLine($"Product: Id: {p.Id} - Name: {p.Name} - Type: {p.Type} - Price: {p.Price} - Tax: {c(p)}");
            }
            return 0;
        }
    }

    
}
