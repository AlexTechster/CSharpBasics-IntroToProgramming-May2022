using System;

namespace P._05.IfConstructions
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int staff = int.Parse(Console.ReadLine());
            double clothing = double.Parse(Console.ReadLine());

            double decor = budget * 0.1;
            if (staff > 150)
            {
                clothing = clothing * 0.9;
            }
            double clothingCost = staff * clothing;
            double cost = clothingCost + decor;
            double difference = budget - cost;
            if (cost <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {difference:F2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(difference):F2} leva more.");
            }
        }
    }
}
