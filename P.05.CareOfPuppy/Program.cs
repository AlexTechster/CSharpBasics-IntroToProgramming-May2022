using System;

namespace P._05.CareOfPuppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodInKg = int.Parse(Console.ReadLine());
            int foodInGrams = foodInKg * 1000;
            int difference = 0;
            int totalFoodIntake = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Adopted")
                {
                    break;
                }
                int foodIntake = int.Parse(command);
                totalFoodIntake += foodIntake;
                

               
            }
            difference = foodInGrams - totalFoodIntake;
            if (totalFoodIntake <= foodInGrams)
            {
                Console.WriteLine($"Food is enough! Leftovers: {difference} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {Math.Abs(difference)} grams more.");
            }
        }
    }
}
