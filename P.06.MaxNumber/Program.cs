using System;

namespace P._06.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            int maxValue = int.MinValue;

            while ((command = Console.ReadLine()) != "Stop")
            {
                int number = int.Parse(command);
                if (number > maxValue)
                {
                    maxValue = number;
                }
            }
            Console.WriteLine(maxValue);
        }
    }
}
