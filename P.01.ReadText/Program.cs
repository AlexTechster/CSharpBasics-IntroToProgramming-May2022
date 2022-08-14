using System;

namespace P._01.ReadText
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            while ((word = Console.ReadLine()) != "Stop")
            {
                Console.WriteLine(word);
            }
        }
    }
}
