using System;

namespace P._10.OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int oddPosSum = 0;
            int evenPosSum = 0;

            for (int i = 1; i <= n; i ++)
            {
                int currNumber = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenPosSum += currNumber;
                }
                else
                {
                    oddPosSum += currNumber;
                }
            }
            if (evenPosSum == oddPosSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + evenPosSum);
            }
            else
            {
                int diff = Math.Abs(evenPosSum - oddPosSum);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            }
        }
    }
}
