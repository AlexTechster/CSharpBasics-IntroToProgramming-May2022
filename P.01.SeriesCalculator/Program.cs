using System;

namespace P._01.SeriesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int seasons = int.Parse(Console.ReadLine());
            int episodes = int.Parse(Console.ReadLine());
            double duration = double.Parse(Console.ReadLine());
            double time = seasons * episodes * duration * 1.2 + (seasons * 10);
            Console.WriteLine($"Total time needed to watch the {movie} series is {time} minutes.");


        }
    }
}
