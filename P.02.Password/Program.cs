using System;

namespace P._02.Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            string enteredPassword;

            while ((enteredPassword = Console.ReadLine()) != password)
            { }
            Console.WriteLine($"Welcome {username}!");

        }
    }
}
