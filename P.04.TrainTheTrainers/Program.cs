using System;

namespace P._04.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int jury = int.Parse(Console.ReadLine());
            string presentation = "";
            double averageScore = 0;
            double finalAssessmentModifier = 0;
            double finalAssessment = 0;
            int counter = 0;

            while ((presentation = Console.ReadLine()) != "Finish")
            {

                double fullScoreModifier = 0;
                for (int i = 1; i <= jury; i++)
                {
                    double score = double.Parse(Console.ReadLine());
                    fullScoreModifier += score;
                }
                averageScore = fullScoreModifier / jury;
                finalAssessmentModifier += averageScore;
                counter++;
                Console.WriteLine($"{presentation} - {averageScore:f2}.");
            }
            finalAssessment = finalAssessmentModifier / counter;
            Console.WriteLine($"Student's final assessment is {finalAssessment:f2}.");
        }
    }
}
