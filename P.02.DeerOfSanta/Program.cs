using System;

namespace P._02.DeerOfSanta
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfLeave = int.Parse(Console.ReadLine());
            int totalFood = int.Parse(Console.ReadLine());
            double firstDeer = double.Parse(Console.ReadLine());
            double secondDeer = double.Parse(Console.ReadLine());
            double thirdDeer = double.Parse(Console.ReadLine());

            double foodConsumed = (firstDeer + secondDeer + thirdDeer) * daysOfLeave;
            double foodLeft = totalFood - foodConsumed;

            if (foodConsumed <= totalFood)
            {
                Console.WriteLine($"{Math.Floor(foodLeft)} kilos of food left.");
            }
            else
            {
                foodLeft = Math.Abs(foodLeft);
                Console.WriteLine($"{Math.Ceiling(foodLeft)} more kilos of food are needed.");
            }

        }
    }
}
