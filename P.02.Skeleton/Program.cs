using System;

namespace P._02.Skeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeInMinutes = int.Parse(Console.ReadLine());
            int timeInSeconds = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            int speed = int.Parse(Console.ReadLine());

            int time = timeInMinutes * 60 + timeInSeconds;

            double timeOfMarin = length * speed / 100 - (length / 120 * 2.5);
            double difference = 0;
            if (timeOfMarin <= time)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {timeOfMarin:f3}.");
            }
            else
            {
                difference = timeOfMarin - time;
                Console.WriteLine($"No, Marin failed! He was {difference:f3} second slower.");
            }
        }
    }
}
