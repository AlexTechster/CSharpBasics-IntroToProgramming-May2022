using System;

namespace P._05.BestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int goals;
            bool hatTrickCheck = false;
            bool tenGoalsCheck = true;
            int maxValue = int.MinValue;
            string bestPlayer = "";
            while (true)
            {
                name = Console.ReadLine();
                if (name == "END")
                {
                    break;
                }
                goals = int.Parse(Console.ReadLine());
                if (goals >=3)
                {
                    hatTrickCheck = true;
                }
                if (goals >= 10)
                {
                    Console.WriteLine($"{name} is the best player!");
                    Console.WriteLine($"He has scored {goals} goals and made a hat-trick !!!");
                    tenGoalsCheck = false;
                    break;
                }
                if (goals > maxValue)
                {
                    maxValue = goals;
                    bestPlayer = name;
                }
            }
            if (tenGoalsCheck)
            {
                Console.WriteLine($"{bestPlayer} is the best player!");
                if (hatTrickCheck)
                {
                    Console.WriteLine($"He has scored {maxValue} goals and made a hat-trick !!!");
                }
                else
                {
                    Console.WriteLine($"He has scored {maxValue} goals.");
                }
            }
        }
    }
}
