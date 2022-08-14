using System;

namespace P._08.TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournamentsCount = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());
            double pointsInTournament = 0;
            double totalPoints = 0;
            double averagePoints = 0;
            double percentage = 0;
            double wins = 0;

            for (int i = 1; i <= tournamentsCount; i++)
            {
                string stage = Console.ReadLine();
                switch (stage)
                {
                    case "W":
                        pointsInTournament += 2000;
                        wins++;
                        break;
                    case "F":
                        pointsInTournament += 1200;
                        break;
                    case "SF":
                        pointsInTournament += 720;
                        break;
                }
            }
            totalPoints = startingPoints + pointsInTournament;
            averagePoints = pointsInTournament / tournamentsCount;
            percentage = wins / tournamentsCount * 100;


            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
            Console.WriteLine($"{percentage:f2}%");
        }
    }
}
