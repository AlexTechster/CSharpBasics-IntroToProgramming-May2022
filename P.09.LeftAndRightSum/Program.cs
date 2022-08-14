using System;

namespace P._10.OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int leftSum = 0;

            for (int i = 1; i <= n; i++)
            {
                leftSum = leftSum + int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            int m = n;
            int rightSum = 0;

            for (int i = 1; i <= m; i++)
            {
                rightSum = rightSum + int.Parse(Console.ReadLine());
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = " + leftSum);
            }
            else
            {
                int diff = Math.Abs(leftSum - rightSum);
                Console.WriteLine("No, diff = " + diff);
            }
        }
    }
}
