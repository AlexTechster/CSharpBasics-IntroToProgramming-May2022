using System;

namespace P._08.DayOfTheWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commission = 0;

            if (city == "Sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commission = sales * 0.05;
                    Console.WriteLine($"{commission:F2}");
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = sales * 0.07;
                    Console.WriteLine($"{commission:F2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = sales * 0.08;
                    Console.WriteLine($"{commission:F2}");
                }
                else if (sales > 10000)
                {
                    commission = sales * 0.12;
                    Console.WriteLine($"{commission:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commission = sales * 0.045;
                    Console.WriteLine($"{commission:F2}");
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = sales * 0.075;
                    Console.WriteLine($"{commission:F2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = sales * 0.10;
                    Console.WriteLine($"{commission:F2}");
                }
                else if (sales > 10000)
                {
                    commission = sales * 0.13;
                    Console.WriteLine($"{commission:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commission = sales * 0.055;
                    Console.WriteLine($"{commission:F2}");
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = sales * 0.08;
                    Console.WriteLine($"{commission:F2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = sales * 0.12;
                    Console.WriteLine($"{commission:F2}");
                }
                else if (sales > 10000)
                {
                    commission = sales * 0.145;
                    Console.WriteLine($"{commission:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
