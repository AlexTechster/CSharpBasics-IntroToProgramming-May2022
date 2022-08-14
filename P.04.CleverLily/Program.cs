using System;

namespace P._04.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceOfWashingMachine = double.Parse(Console.ReadLine());
            int priceOfToy = int.Parse(Console.ReadLine());

            double total = 0;
            double difference = 0;
            double money = 0;
            double cashGift = 10;
            int toy = 0;

            for (int birthday = 1; birthday <= age; birthday++)
            {
                if (birthday % 2 == 0)
                {
                    money += cashGift;
                    money--;
                    cashGift += 10;
                }
                else
                {
                    toy++;
                }

            }
            priceOfToy = toy * priceOfToy;
            total = money + priceOfToy;
            difference = total - priceOfWashingMachine;
            
            if (difference >= 0)
            {
                Console.WriteLine($"Yes! {difference:f2}");
            }
            else
            {
                Console.WriteLine($"No! {Math.Abs(difference):f2}");
            }
            

        }
    }
}
