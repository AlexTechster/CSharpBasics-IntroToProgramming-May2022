using System;

namespace P._06.Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double academyScore = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double difference = 0;
            double sumScore = 0;

            for (int i = 0; i < n; i++)
            {
                string joury = Console.ReadLine();
                int length = joury.Length;
                double points = double.Parse(Console.ReadLine());
                sumScore = length * points / 2;
                academyScore += sumScore;
            
            
                if (academyScore >= 1250.5)
                {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {academyScore:f1}!");
                    break;
                }
            }
            if (academyScore < 1250.5)
            {
                difference = 1250.5 - academyScore;
                Console.WriteLine($"Sorry, {actorName} you need {difference:f1} more!");
            }
        }
    }
}
