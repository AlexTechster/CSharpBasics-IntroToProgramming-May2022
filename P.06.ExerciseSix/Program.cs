using System;

namespace P._06.ExerciseSix
{
    class Program
    {
        static void Main(string[] args)
        {
            string series = Console.ReadLine();
            int episodeLength = int.Parse(Console.ReadLine());
            int breakLength = int.Parse(Console.ReadLine());

            double freeBreak = breakLength * 0.625;
            double difference = freeBreak - episodeLength;

            if (episodeLength <= freeBreak)
            {
                Console.WriteLine($"You have enough time to watch {series} and left with {Math.Ceiling(difference)} minutes free time.");
            }
            else
            {
                difference = Math.Abs(difference);
                Console.WriteLine($"You don't have enough time to watch {series}, you need {Math.Ceiling(difference)} more minutes.");
            }

        }
    }
}
