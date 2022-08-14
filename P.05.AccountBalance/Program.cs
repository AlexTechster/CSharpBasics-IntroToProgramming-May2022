using System;

namespace P._05.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            string endGame;

            while ((endGame = Console.ReadLine()) != "NoMoreMoney")
            {
                double moneyToIncrease = double.Parse(endGame);
                if (moneyToIncrease < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                total += moneyToIncrease;
                Console.WriteLine($"Increase: {moneyToIncrease:f2}");
            }
            Console.WriteLine($"Total: {total:f2}");
        }
    }
}
