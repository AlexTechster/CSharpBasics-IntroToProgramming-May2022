using System;

namespace P._03.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp = double.Parse(Console.ReadLine());

            if (temp >= 26.00 && temp <= 35.00)
            {
                Console.WriteLine("Hot");
            }
            else if (temp >= 20.1 && temp <= 25.9)
            {
                Console.WriteLine("Warm");
            }
            else if (temp >= 15.00 && temp <= 20.00)
            {
                Console.WriteLine("Mild");
            }
            else if (temp >= 12.00 && temp <= 14.9)
            {
                Console.WriteLine("Cool");
            }
            else if (temp >= 5.00 && temp <= 11.9)
            {
                Console.WriteLine("Cold");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
