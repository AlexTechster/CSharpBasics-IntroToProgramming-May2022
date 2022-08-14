using System;

namespace P._01.NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 1;
            bool isTrue = false;

            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols  = 1; cols <= rows; cols++)
                {
                    if (counter > n)
                    {
                        isTrue = true;
                        break;
                    }
                    Console.Write(counter + " ");
                    counter++;
                }
                if (isTrue)
                {
                    break;
                }
                Console.WriteLine();
            }

        }
    }
}
