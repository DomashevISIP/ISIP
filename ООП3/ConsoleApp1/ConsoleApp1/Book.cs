using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Book
    {
        private string author = "unknown";
        private string title = "unknown";
        private string pages = "unknown";
        private bool collectorsEdition = false;



        public Book(string author, string title, string pages, bool collectorsEdition)
        {
            this.author = author;
            this.title = title;
            this.pages = pages;
            this.collectorsEdition = collectorsEdition;
        }
        public Book()
        {
            author = "unknown";
            title = "unknown";
            pages = "unknown";
            collectorsEdition = false;
        }

        public Book(string author, string title, bool collectorsEdition)
        {
            this.author = author;
            this.title = title;
            this.collectorsEdition = collectorsEdition;
        }

        public Book(string title, bool collectorsEdition)
        {
            this.title = title;
            this.collectorsEdition = collectorsEdition;
        }

        public void Output()
        {
            Console.WriteLine();
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Pages: " + pages);
            Console.WriteLine("Collector's Edition: " + collectorsEdition);
            Console.WriteLine();
            Console.WriteLine("############################");
        }
     
    }
}
