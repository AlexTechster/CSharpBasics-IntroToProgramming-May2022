using System;

namespace P._08.OnTimeForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());
            int examStartInMinutes = examHour * 60 + examMinutes;
            int arrivalInMinutes = arrivalHour * 60 + arrivalMinutes;
            int differenceInTotalMinutes = examStartInMinutes - arrivalInMinutes;
            int differenceinTotalHours = differenceInTotalMinutes / 60;
            int remainingMinutesInDifference = differenceInTotalMinutes % 60;

            if (differenceInTotalMinutes >= 0 && differenceInTotalMinutes <= 30)
            {
                Console.WriteLine("On time");
                if (differenceInTotalMinutes > 0)
                {
                    Console.WriteLine($"{differenceInTotalMinutes} minutes before the start");
                }

            }
            else if (differenceInTotalMinutes > 30)
            {
                Console.WriteLine("Early");
                if (differenceinTotalHours == 0)
                {
                    Console.WriteLine($"{remainingMinutesInDifference} minutes before the start");
                }
                else
                {
                    Console.WriteLine($"{differenceinTotalHours}:{remainingMinutesInDifference:d2} hours before the start");
                }

            }
            else if (differenceInTotalMinutes < 0)
            {
                Console.WriteLine("Late");
                if (differenceinTotalHours == 0)
                {
                    Console.WriteLine($"{Math.Abs(remainingMinutesInDifference)} minutes after the start");
                }
                else
                {
                    Console.WriteLine($"{Math.Abs(differenceinTotalHours)}:{Math.Abs(remainingMinutesInDifference):d2} hours after the start");
                }
            }
        }
    }
}
