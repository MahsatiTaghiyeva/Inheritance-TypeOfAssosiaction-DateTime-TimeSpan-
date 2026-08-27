using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    //Productdan miras alır ve Genre ozelliyi var;
    internal class Book: Product
    {
        public string Genre ="";
        //Genre dəyəri təyin olunmadan Book yaradıla bilməz
        public Book(string name, double price, string genre) : base(name,price)
        {
            Genre = genre;
        }

}
}
