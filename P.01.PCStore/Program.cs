using System;

namespace P._01.PCStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfCPU = double.Parse(Console.ReadLine());
            double priceOfGPU = double.Parse(Console.ReadLine());
            double priceOfRAM = double.Parse(Console.ReadLine());
            int ramSticks = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());
            double totalMoneyNeeded = 0;

            totalMoneyNeeded = (priceOfCPU + priceOfGPU) * (1 - discount) + priceOfRAM * ramSticks;
            totalMoneyNeeded = totalMoneyNeeded * 1.57;

            Console.WriteLine($"Money needed - {totalMoneyNeeded:f2} leva.");
        }
    }
}
