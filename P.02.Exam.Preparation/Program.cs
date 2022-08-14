using System;

namespace P._02.Exam.Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int failedThreshold = int.Parse(Console.ReadLine());
            int failedTimes = 0;
            int solvedProblemsCount = 0;
            double gradesSum = 0;
            string lastProblem = "";
            bool isFailed = true;
            string problemName;

            while (failedTimes < failedThreshold)
            {
                problemName = Console.ReadLine();
                if ("Enough" == problemName)
                {
                    isFailed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    failedTimes++;
                }
                gradesSum += grade;
                solvedProblemsCount++;
                lastProblem = problemName;
            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {failedThreshold} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradesSum / solvedProblemsCount:f2}");
                Console.WriteLine($"Number of problems: {solvedProblemsCount}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
