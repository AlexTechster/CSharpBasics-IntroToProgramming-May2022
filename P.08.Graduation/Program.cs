using System;

namespace P._08.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            double totalGrades = 0;
            int currClass = 1;
            int repeatCnt = 0;
            while (currClass <= 12)
            {
                double currClassGrade = double.Parse(Console.ReadLine());
                totalGrades += currClassGrade;
                if (currClassGrade < 4)
                {
                    repeatCnt++;
                    if (repeatCnt > 1)
                    {
                        break;
                    }
                    continue;
                }
               
                currClass++;
            }
            if (repeatCnt > 1)
            {
                Console.WriteLine($"{name} has been excluded at {currClass} grade");
            }
            else
            {
                double averageGrade = totalGrades / (currClass - 1 + repeatCnt);
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
            }
        }
    }
}
