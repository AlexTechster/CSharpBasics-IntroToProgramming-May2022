using System;

namespace P._07.Pipeline
{
    class Program
    {
        static void Main(string[] args)
        {
            int freeDays = int.Parse(Console.ReadLine());
            int busyDays = 365 - freeDays;

            int freeDaysPlay = freeDays * 127;
            int busyDaysPlay = busyDays * 63;
            int totalPlay = freeDaysPlay + busyDaysPlay;
            int norm = 30000;
            int totalMinutes = totalPlay - norm;
            int hours = Math.Abs(totalMinutes) / 60;
            int minutes = Math.Abs(totalMinutes) % 60;
            if (totalPlay > norm)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
        }
    }
}
