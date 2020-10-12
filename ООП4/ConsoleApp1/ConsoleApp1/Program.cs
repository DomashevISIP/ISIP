using System;

namespace ConsoleApp1
{
    class Book
    {
        private string Name = "unknown";
        private string Fumilia = "unknown";
        private string pages = "unknown";
        private bool collectorsEdition = false;



        public Book(string Name, string Fumilia, string pages, bool collectorsEdition)
        {
            this.Name = Name;
            this.Fumilia= Fumilia;
            this.pages = pages;
            this.collectorsEdition = collectorsEdition;
        }
        public Book()
        {
            Name = "unknown";
            Fumilia = "unknown";
            pages = "unknown";
            collectorsEdition = false;
        }

        public Book(string Name, string Fumilia, bool collectorsEdition)
        {
            this.Name = Name;
            this.Fumilia = Fumilia;
            this.collectorsEdition = collectorsEdition;
        }

        public Book(string Fumilia, bool collectorsEdition)
        {
            this.Fumilia = Fumilia;
            this.collectorsEdition = collectorsEdition;
        }

        public void Output()
        {
            Console.WriteLine();
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Fumilia: " + Fumilia);
            Console.WriteLine("Pages: " + pages);
            Console.WriteLine("Collector's Edition: " + collectorsEdition);
            Console.WriteLine();
            Console.WriteLine("-----------------");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Book bouk1 = new Book("Aleksandr", "Pushkin", "546", false);
            Book bouk2 = new Book("Lev", "Tolstoy", "724", false);
            Book bouk3 = new Book("Aleksandr", "Block", "285", false);
            Book bouk4 = new Book("Cergey", "Esenin", true);
            bouk1.Output();
            bouk2.Output();
            bouk3.Output();
            bouk4.Output();
            Console.ReadKey();
        }
    }
}
