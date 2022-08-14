using System;

namespace P._01.Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int hour = 0; hour <= 23; hour++)
            {
                for (int minute = 0; minute <= 59; minute++)
                {
                    for (int second = 0; second <= 59; second++)
                    {
                        Console.WriteLine($"{hour:d2}:{minute:d2}:{second:d2}");
                        System.Threading.Thread.Sleep(1000);
                    }
                }
            }

        }
    }
}
