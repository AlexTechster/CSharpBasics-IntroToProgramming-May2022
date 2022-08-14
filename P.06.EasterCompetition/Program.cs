using System;

namespace P._06.EasterCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int kozunakCount = int.Parse(Console.ReadLine());
            int maxValue = int.MinValue;
            string leadingChef = "";

            for (int i = 1; i <= kozunakCount; i++)
            {
                int points = 0;
                string chef = Console.ReadLine();

                while (true)
                {
                    string command = Console.ReadLine();
                    if (command == "Stop")
                    {
                        break;
                    }
                    int score = int.Parse(command);
                    points += score;

                }
                Console.WriteLine($"{chef} has {points} points.");
                if (points > maxValue)
                {
                    maxValue = points;
                    leadingChef = chef;
                    Console.WriteLine($"{chef} is the new number 1!");
                }

            }
            Console.WriteLine($"{leadingChef} won competition with {maxValue} points!");
        }
    }
}
