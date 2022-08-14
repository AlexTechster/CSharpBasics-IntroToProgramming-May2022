using System;

namespace P._07.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int apartmentVolume = width * lenght * height;

            string command;

            while ((command = Console.ReadLine()) != "Done")
            {
                int box = int.Parse(command);
                apartmentVolume -= box;
                if (apartmentVolume < 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(apartmentVolume)} Cubic meters more.");
                    break;
                }
            }
            if (apartmentVolume >= 0)
            {
                Console.WriteLine($"{apartmentVolume} Cubic meters left.");
            }
        }
    }
}
