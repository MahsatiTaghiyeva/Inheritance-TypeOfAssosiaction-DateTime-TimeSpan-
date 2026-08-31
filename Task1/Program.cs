using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count of books: ");
            int n = Convert.ToInt32(Console.ReadLine());
            //ayi daxil etdikden sonra hemin uzunluqda bir book arrayi yaradilmalidir
            Book[] books = new Book[n];
            //daha sonra verdiyimiz say defe bizden book ucun lazim olan butun inputlari daxil etmeyimizi istemelidi, dovrun her stepinde yeni bir book obyekti yaranib array-e elave edilmelidir .
            for(int i = 0; i < n; i++)
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
            while(true){
                Console.WriteLine("Menu:");
                Console.WriteLine("----------------------------");
                Console.WriteLine("1. Filter books by price");
                Console.WriteLine("2. Show all books");
                Console.WriteLine("0. Exit");
                Console.WriteLine("----------------------------");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 0)
                {
                    Console.WriteLine("GoodBye!...");
                    break;
                }
                else if (choice == 1)
                {
                    for (int i = 0; i < books.Length - 1; i++)
                    {
                        for (int j = 0; j < books.Length - 1 - i; j++)
                        {
                            if (books[j].Price > books[j + 1].Price)
                            {
                                Book temp = books[j];
                                books[j] = books[j + 1];
                                books[j + 1] = temp;
                            }
                        }
                    }
                    Console.WriteLine("Books sorted by price:");
                    for (int i = 0; i < books.Length; i++)
                    {
                        books[i].Detail();
                    }
                
                }

                else if (choice == 2)
                {
                    for (int i = 0; i < n; i++)
                    {
                        books[i].Detail();
                    }
                }
                else
                {
                Console.WriteLine("Wrong choice!");
                }
            }
        }
    }
//daha sonra verdiyimiz say defe bizden book ucun lazim olan butun inputlari daxil etmeyimizi istemelidi, dovrun her stepinde yeni bir book obyekti yaranib array-e elave edilmelidir .