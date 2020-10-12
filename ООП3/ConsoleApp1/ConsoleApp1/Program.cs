using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Phil Knight", "Shoe Dog: A Memoir by the Creator of Nike", "386", false);
            Book book2 = new Book("Eric Berne", "Games People Play", "216", false);
            Book book3 = new Book("Paul Chaloner", "This is Esports", "256", false);
            Book book4 = new Book("George R. R. Martin", "A Song of Ice and Fire", true);
            book1.Output();
            book2.Output();
            book3.Output();
            book4.Output();
            Console.ReadKey();
        }
    }
}
