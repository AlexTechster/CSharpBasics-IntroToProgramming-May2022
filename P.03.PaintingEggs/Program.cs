using System;

namespace P._03.PaintingEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            string size = Console.ReadLine();
            string color = Console.ReadLine();
            int series = int.Parse(Console.ReadLine());
            int price = 0;
            double sum = 0;

            if (size == "Large")
            {
                switch (color)
                {
                    case "Red":
                        price = 16;
                        break;
                    case "Green":
                        price = 12;
                        break;
                    case "Yellow":
                        price = 9;
                        break;
                }
            }
            else if (size == "Medium")
            {
                switch (color)
                {
                    case "Red":
                        price = 13;
                        break;
                    case "Green":
                        price = 9;
                        break;
                    case "Yellow":
                        price = 7;
                        break;
                }
            }
            else if (size == "Small")
            {
                switch (color)
                {
                    case "Red":
                        price = 9;
                        break;
                    case "Green":
                        price = 8;
                        break;
                    case "Yellow":
                        price = 5;
                        break;
                }
            }
            sum = series * price;
            sum = sum * 0.65;
            Console.WriteLine($"{sum:f2} leva.");
        }
    }
}
