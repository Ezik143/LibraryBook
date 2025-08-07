using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookClass;
namespace Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("test");
            Console.WriteLine("Book 1 DEFAULT");
            book1.displayInfo();
            Book book2 = new Book("test2", "author2");
            Console.WriteLine("Book 2 BASIC");
            book2.displayInfo();
            Book book3 = new Book("test3", "author3", 2023);
            Console.WriteLine("Book 3 DETAILED");
            book3.displayInfo();
            Book book4 = new Book("test4", "author4", 2023, "genre4");
            Console.WriteLine("Book 4 COMPLETE");
            book4.displayInfo();
        }
    }
}
