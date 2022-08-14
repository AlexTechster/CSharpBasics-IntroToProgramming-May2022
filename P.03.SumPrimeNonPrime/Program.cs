using System;

namespace P._03.SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string number;
            int sumPrime = 0;
            int sumNonPrime = 0;
            while ((number = Console.ReadLine()) != "stop")
            {
               
                int n = int.Parse(number);

                bool numIsPrime = true;
                if (n < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }

                for (int divider = 2; divider < n; divider++)
                {
                    int remainder = n % divider;
                    if (remainder == 0)
                    {
                        sumNonPrime += n;
                        numIsPrime = false;
                        break;
                    }
                }
                if (numIsPrime)
                {
                    sumPrime += n;
                }

            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}
