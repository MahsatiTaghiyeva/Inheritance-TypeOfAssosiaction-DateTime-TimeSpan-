using System;
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

