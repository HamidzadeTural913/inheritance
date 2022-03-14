using System;

namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Elxan.E", "detective", "2015", 18, 250);
            Newspaper newspaper = new Newspaper("TV", "Sunami", "2012", 2, 20);
            Console.WriteLine(book.ALL());
            book.Sell();
            Console.WriteLine(newspaper.ALL1());
            newspaper.Sell();
            
        }
    }
}