using System;

namespace P._07.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            int minValue = int.MaxValue;

            while ((command = Console.ReadLine()) != "Stop")
            {
                int number = int.Parse(command);
                if (number < minValue)
                {
                    minValue = number;
                }
            }
            Console.WriteLine(minValue);
        }
    }
}
