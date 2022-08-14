using System;

namespace P._08.NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int minNum = int.MaxValue;
            int maxNum = int.MinValue;

            for (int i = 1; i <= n; i++)
            {
                int currNumber = int.Parse(Console.ReadLine());
                if (currNumber < minNum)
                {
                    minNum = currNumber;
                }
                if (currNumber > maxNum)
                {
                    maxNum = currNumber;
                }
            }
            Console.WriteLine($"Max number: {maxNum}");
            Console.WriteLine($"Min number: {minNum}");
        }
    }
}
