using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Product class yaradin (Name,Price,Count) 
namespace ConsoleApp45
{
    internal class Product
    {
        public string Name = "";
        public double Price;
        public int Count;

        //Detail methodu olsun Product haqqinda butun melumatlari geriye qaytarsin
        public void Detail(string Name, double Price, int Count)
        {
            Console.WriteLine($"Product Name: {Name}, Price: {Price}, Count: {Count}");
        }

        //Discount methodu olsun (int) endirim faizi qebul etsin ve geriye productin satis price-ni yazdirsin.
        public void Discount(double Price, int Percentage)
        {
            double newPrice = Price - (Price * Percentage / 100);
            Console.WriteLine($"New Price: {newPrice}");
        }
        //Name ve Price dəyərləri təyin olunmadan Product obyekti yaradıla bilməz
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
