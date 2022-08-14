using System;

namespace P._03.Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 0;
            for (int n1 = 0; n1 <= n; n1++)
            {
                for (int n2 = 0; n2 <= n; n2++)
                {
                    for (int n3 = 0; n3 <= n; n3++)
                    {
                        int sum = n1 + n2 + n3;
                        if (sum == n)
                        {
                            counter++;
                        }
                        
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
