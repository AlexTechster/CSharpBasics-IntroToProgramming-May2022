using System;

namespace P._04.ExcellentResult
{
    class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();

            if (shape == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double areaA = a * a;
                Console.WriteLine(areaA);
            }
            else if (shape == "rectangle")
            {
                double a1 = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());

                double areaB = a1 * b;
                Console.WriteLine(areaB);
            }
            else if (shape == "circle")
            {
                double r = double.Parse(Console.ReadLine());

                double areaC = Math.PI * r * r;
                Console.WriteLine(areaC);
            }
            else if (shape == "triangle")
            {
                double a2 = double.Parse(Console.ReadLine());
                double b2 = double.Parse(Console.ReadLine());

                double areaD = a2 * b2 / 2;
                Console.WriteLine(areaD);
            }
        }
    }
}
