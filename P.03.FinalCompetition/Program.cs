using System;

namespace P._03.FinalCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int dancers = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();
            double percentageModifier = 0;
            double totalPrize = 0.0;
            double charity = 0.0;
            double prizePerDancer = 0.0;

            if (place == "Bulgaria")
            {
                switch (season)
                {
                    case "summer":
                        percentageModifier = 0.95;
                        break;
                    case "winter":
                        percentageModifier = 0.92;
                        break;
                }
                totalPrize = (dancers * points) * percentageModifier;

            }
            else if (place == "Abroad")
            {
                switch (season)
                {
                    case "summer":
                        percentageModifier = 0.90;
                        break;
                    case "winter":
                        percentageModifier = 0.85;
                        break;
                }
                totalPrize = ((dancers * points) * 1.5) * percentageModifier;
            }
            charity = totalPrize * 0.75;
            prizePerDancer = (totalPrize - charity) / dancers;
            Console.WriteLine($"Charity - {charity:f2}");
            Console.WriteLine($"Money per dancer - {prizePerDancer:f2}");
        }
    }
}
