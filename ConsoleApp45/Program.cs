using System;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count of books: ");
            int count = Convert.ToInt32(Console.ReadLine());
            //ayi daxil etdikden sonra hemin uzunluqda bir book arrayi yaradilmalidir
            Book[] books = new Book[count];
            //daha sonra verdiyimiz say defe bizden book ucun lazim olan butun inputlari daxil etmeyimizi istemelidi, dovrun her stepinde yeni bir book obyekti yaranib array-e elave edilmelidir .
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Price: ");
                double price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Genre: ");
                string genre = Console.ReadLine();
                books[i] = new Book(name, price, genre);
                Console.WriteLine("----------------------------");
            }
            //Arrayi tam olaraq doldurduqdan sonra menu penceresi gorunmelidir console - da ve orada asagidaki kimi yazilmalidir:
            //1.Kitablari qiymete gore filterle
            //2.Butun kitablari goster
            //0.Proqrami bagla
            Console.WriteLine("Menu:");
            Console.WriteLine("----------------------------");
            Console.WriteLine("1. Filter books by price");
            Console.WriteLine("2. Show all books");
            Console.WriteLine("0. Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 0)
            {
                Console.WriteLine("GoodBye!...");
            }
            if (choice == 1)
            {
                
            }

            else if (choice == 2)
            {
                for (int i = 0; i < count; i++)
                {
                    books[i].Detail();
                }
            }
        }
    }
}
//daha sonra verdiyimiz say defe bizden book ucun lazim olan butun inputlari daxil etmeyimizi istemelidi, dovrun her stepinde yeni bir book obyekti yaranib array-e elave edilmelidir .