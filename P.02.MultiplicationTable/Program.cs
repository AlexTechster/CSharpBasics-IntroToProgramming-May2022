using System;

namespace P._02.MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int firstMultiplier = 1; firstMultiplier <= 10; firstMultiplier++)
            {
                int result;
                for (int secondMultiplier = 1; secondMultiplier <=10; secondMultiplier++)
                {
                    result = firstMultiplier * secondMultiplier;
                    Console.WriteLine($"{firstMultiplier} * {secondMultiplier} = {result}");
                }
            }
        }
    }
}
