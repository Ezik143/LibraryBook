using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookClass
{
    public class Book
    {
        private string title;
        private string author;
        private int yearPublished;
        private string genre;


        public Book()
        {
            title = "Unknown";
            author = "Unknown";
            yearPublished = 0;
            genre = "Unknown";
        }

        public Book(string title_)
        {
            title = title_;
            author = "Unknown";
            yearPublished = 0;
            genre = "Unknown";
        }

        public Book(string title_, string author_)
        {
            title = title_;
            author = author_;
            yearPublished = 0;
            genre = "Unknown";
        }

        public Book(string title_, string author_, int yearPublished_)
        {
            title = title_;
            author = author_;
            yearPublished = yearPublished_;
            genre = "Unknown";
        }
        public Book(string title_, string author_, int yearPublished_, string genre_)
        {
            title = title_;
            author = author_;
            yearPublished = yearPublished_;
            genre = genre_;
        }

        public void displayInfo()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Year Published: " + yearPublished);
            Console.WriteLine("Genre: " + genre);
            Console.WriteLine("-----------------------------");
        }
    }
}
