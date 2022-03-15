using Mushfig.Model;
using System;

namespace Mushfig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zehmet olmasa reqem daxil edin");
            int number = Convert.ToInt32(Console.ReadLine());

            Book[] books = new Book[number];
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Zehmet olmasa no daxil edin");
                int no = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Zehmet olmasa name daxil edin");
                string name = Console.ReadLine();
                Console.WriteLine("Zehmet olmasa price daxil edin");
                double price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Zehmet olmasa genre daxil edin");
                string genre = Console.ReadLine();
                Book book = new Book(no, name, price, genre);
                books[i] = book;
            }

            Console.WriteLine("Bir reqem daxil edin");
            Console.WriteLine("1. Kitablari qiymete gore filterle");
            Console.WriteLine("2. Butun kitablari goster");
            Console.WriteLine("0. Proqrami bagla");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    Console.WriteLine("Minimum ve Max deyerleri daxil edin");
                    double min = Convert.ToDouble(Console.ReadLine());
                    double max = Convert.ToDouble(Console.ReadLine());
                    FilterBooks(books, min, max);
                    break;
                case 2:
                    PrintBooks(books);
                    break;
                default: Environment.Exit(0); break;
            }
        }
        public static void PrintBooks(Book[] books)
        {
            for (int i = 0; i < books.Length; i++)
            {
                PrintBook(books[i]);
            }
        }

        public static void FilterBooks(Book[] books, double min, double max)
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].Price >= min && books[i].Price <= max)
                {
                    PrintBook(books[i]);
                }
            }
        }

        public static void PrintBook(Book book)
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("No : " + book.No);
            Console.WriteLine("Name : " + book.Name);
            Console.WriteLine("Price : " + book.Price);
            Console.WriteLine("Genre : " + book.Genre);
            Console.WriteLine("-------------------");
        }


    }
}
