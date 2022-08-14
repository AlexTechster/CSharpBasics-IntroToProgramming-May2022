using System;

namespace P._02.HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;
            int diff = 0;
            
            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(Console.ReadLine());
                sum += m;
                
                if (m > max)
                {
                    max = m;
                }
            }
            sum -= max;
            if (sum == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                diff = sum - max;
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(diff)}");
            }
        }
    }
}
