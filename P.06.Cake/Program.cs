using System;

namespace P._06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            int cakeArea = width * lenght;

            string command;
            while ((command = Console.ReadLine()) != "STOP")
            {
                int piece = int.Parse(command);
                cakeArea -= piece;

                if (cakeArea < 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cakeArea)} pieces more.");
                    break;
                }
            }
            if (cakeArea >= 0)
            {
                Console.WriteLine($"{cakeArea} pieces are left.");
            }
        }
    }
}
