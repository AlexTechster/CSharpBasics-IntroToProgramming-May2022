using System;

namespace P._06.Substitute
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            
            int firstNumber = 0;
            int secondNumber = 0;
            int thirdNumber = 0;
            int fourthNumber = 0;
            int validCount = 0;
            for (int i = k; i <= 8; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }
                firstNumber = i;
                
                for (int j = 9; j >= l; j--)
                {
                    if (j % 2 == 0)
                    {
                        continue;
                    }
                    secondNumber = j;
                    
                    for (int y = m; y <= 8; y++)
                    {
                        if (y % 2 != 0)
                        {
                            continue;
                        }
                        thirdNumber = y;
                        
                        for (int z = 9; z >= n; z--)
                        {
                            if (z % 2 == 0)
                            {
                                continue;
                            }
                            fourthNumber = z;
                            if (firstNumber == thirdNumber && secondNumber == fourthNumber)
                            {
                                Console.WriteLine("Cannot change the same player.");
                            }
                            else
                            {
                                Console.WriteLine($"{firstNumber}{secondNumber} - {thirdNumber}{fourthNumber}");
                                validCount++;
                            }
                            if (validCount >= 6)
                            {
                                return;
                            }
                        }
                    }
                }
                

            }
            
            
            

        }
    }
}
