using System;

namespace P._04.SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int counter = 0;
            for (int n1 = start; n1 <= end; n1++)
            {
                for (int n2 = start;  n2 <= end;  n2++)
                {
                    counter++;
                    int currSum = n1 + n2;
                    if (currSum == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{counter} ({n1} + {n2} = {currSum})");
                        return;
                    }
                   
                }
            }
            Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");

        }
    }
}
