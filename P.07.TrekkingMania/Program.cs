using System;

namespace P._07.TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupsNum = int.Parse(Console.ReadLine());
            double musala = 0;
            double montblanc = 0;
            double kilimandjaro = 0;
            double kadve = 0;
            double everest = 0;
            double total = 0;

            for (int i = 1; i <= groupsNum; i++)
            {
                int peopleInGroupNum = int.Parse(Console.ReadLine());

                if (peopleInGroupNum >= 1 && peopleInGroupNum <= 5)
                {
                    musala += peopleInGroupNum;
                }
                else if (peopleInGroupNum >= 6 && peopleInGroupNum <= 12)
                {
                    montblanc += peopleInGroupNum;
                }
                else if (peopleInGroupNum >= 13 && peopleInGroupNum <= 25)
                {
                    kilimandjaro += peopleInGroupNum;
                }
                else if (peopleInGroupNum >= 25 && peopleInGroupNum <= 40)
                {
                    kadve += peopleInGroupNum;
                }
                else if (peopleInGroupNum >= 41)
                {
                    everest += peopleInGroupNum;
                }
            }
            total = musala + montblanc + kilimandjaro + kadve + everest;
            musala = musala / total * 100;
            montblanc = montblanc / total * 100;
            kilimandjaro = kilimandjaro / total * 100;
            kadve = kadve / total * 100;
            everest = everest / total * 100;
            Console.WriteLine($"{musala:f2}%");
            Console.WriteLine($"{montblanc:f2}%");
            Console.WriteLine($"{kilimandjaro:f2}%");
            Console.WriteLine($"{kadve:f2}%");
            Console.WriteLine($"{everest:f2}%");
        }
    }
}
