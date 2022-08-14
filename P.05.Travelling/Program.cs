using System;

namespace P._05.Travelling
{
    class Program
    {
        static void Main(string[] args)
        {

            string destination;
            while ((destination = Console.ReadLine()) != "End")
            {
                double cost = double.Parse(Console.ReadLine());
                double saved = 0.0;
                while (cost != 0)
                {
                    saved = double.Parse(Console.ReadLine());
                    cost -= saved;
                    if (cost <= 0)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        break;
                    }
                }
            }
        }
    }
}
