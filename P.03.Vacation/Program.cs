using System;

namespace P._03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForTrip = double.Parse(Console.ReadLine());
            double currentCash = double.Parse(Console.ReadLine());

            int daysCounter = 0;
            int spendingCounter = 0;
            while (currentCash < moneyForTrip && spendingCounter <5)
            {
                string command = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                daysCounter++;

                if (command == "save")
                {
                    currentCash += money;
                    spendingCounter = 0;
                }
                else if (command == "spend")
                {
                    currentCash -= money;
                    spendingCounter++;
                    if (currentCash <= 0)
                    {
                        currentCash = 0;
                    }
                }

            }
            if (spendingCounter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCounter);
            }
            if (currentCash >= moneyForTrip)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
        }
    }
}
