using System;

namespace P._04.Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = 0;
            int redCounter = 0;
            int orangeCounter = 0;
            int yellowCounter = 0;
            int whiteCounter = 0;
            int blackCounter = 0;
            int otherCounter = 0;

            int n = int.Parse(Console.ReadLine());

            for (int i = n; i > 0; i--)
            {
                string color = Console.ReadLine();

                switch (color)
                {
                    case "red":
                        points += 5;
                        redCounter++;
                        break;
                    case "orange":
                        points += 10;
                        orangeCounter++;
                        break;
                    case "yellow":
                        points += 15;
                        yellowCounter++;
                        break;
                    case "white":
                        points += 20;
                        whiteCounter++;
                        break;
                    case "black":
                        points = points / 2;
                        blackCounter++;
                        break;
                    default:
                        otherCounter++;
                        break;
                }

            }
            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Red balls: {redCounter}");
            Console.WriteLine($"Orange balls: {orangeCounter}");
            Console.WriteLine($"Yellow balls: {yellowCounter}");
            Console.WriteLine($"White balls: {whiteCounter}");
            Console.WriteLine($"Other colors picked: {otherCounter}");
            Console.WriteLine($"Divides from black balls: {blackCounter}");
        }
    }
}
