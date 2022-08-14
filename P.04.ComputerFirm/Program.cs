using System;

namespace P._04.ComputerFirm
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rating = 0;
            double percentageOfSales = 0.0;
            double realSales = 0.0;
            double realSalesSum = 0.0;
            int ratingSum = 0;
            double ratingSumAverage = 0.0;


            for (int i = 1; i <= n; i++)
            {
                int protoRating = int.Parse(Console.ReadLine());
                int possibleSales = 0;
                rating = protoRating % 10;

                if (rating < 2 || rating > 6)
                {
                    break;
                }
                switch (rating)
                {
                    case 2:
                        percentageOfSales = 0.0;
                        break;
                    case 3:
                        percentageOfSales = 0.5;
                        break;
                    case 4:
                        percentageOfSales = 0.7;
                        break;
                    case 5:
                        percentageOfSales = 0.85;
                        break;
                    case 6:
                        percentageOfSales = 1;
                        break;
                }
                possibleSales = protoRating / 10;
                realSales = possibleSales * percentageOfSales;
                realSalesSum += realSales;
                ratingSum += rating;
            }
            ratingSumAverage = (double)ratingSum / n;
            Console.WriteLine($"{realSalesSum:f2}");
            Console.WriteLine($"{ratingSumAverage:f2}");

        }
    }
}
