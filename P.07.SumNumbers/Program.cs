﻿using System;

namespace P._07.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int currNumber = int.Parse(Console.ReadLine());
                sum = sum + currNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
