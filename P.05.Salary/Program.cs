using System;

namespace P._05.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int openTabsNum = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            for (int i = 1; i <= openTabsNum; i++)
            {
                string websiteName = Console.ReadLine();

                switch(websiteName)
                {
                    case "Facebook":
                        salary -= 150;
                        break;
                    case "Instagram":
                        salary -= 100;
                        break;
                    case "Reddit":
                        salary -= 50;
                        break;
                }
            }
            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine($"{salary}");
            }
        }
    }
}
