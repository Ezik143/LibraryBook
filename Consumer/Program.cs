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
            book1.displayInfo();
            Book book2 = new Book("test2", "author2");
            book2.displayInfo();
            Book book3 = new Book("test3", "author3", 2023);
            book3.displayInfo();
            Book book4 = new Book("test4", "author4", 2023, "genre4");
            book4.displayInfo();
        }
    }
}
