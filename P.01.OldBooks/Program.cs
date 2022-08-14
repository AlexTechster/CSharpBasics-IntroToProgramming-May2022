using System;

namespace P._01.OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookToFind = Console.ReadLine();
            string book;
            int bookCount = 0;
            while ((book = Console.ReadLine()) != bookToFind)
            {
                if (book == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {bookCount} books.");
                    break;
                }
                bookCount++;
            }
            if (book != "No More Books")
            {
                Console.WriteLine($"You checked {bookCount} books and found it.");
            }
        }
    }
}
