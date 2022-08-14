using System;

namespace P._04.Steps
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalSteps = 0;
            int difference = 0;

            while (totalSteps < 10000)
            {
                string input = Console.ReadLine();
                

                if (input == "Going home")
                {
                    int lastSteps = int.Parse(Console.ReadLine());
                    totalSteps += lastSteps;
                    break;
                }
                int steps = int.Parse(input);

                totalSteps += steps;
            }
            difference = totalSteps - 10000;
            if (totalSteps >= 10000)
            {
                
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{difference} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{Math.Abs(difference)} more steps to reach goal.");
                
            }
        }
    }
}
