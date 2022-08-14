using System;

namespace P._02.NumbersNTo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            for (int i = a ; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
