using System;

namespace P._09.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfVisit = int.Parse(Console.ReadLine());
            string accomodation = Console.ReadLine();
            string review = Console.ReadLine();

            int stay = daysOfVisit - 1;
            double accomodationPrice = 0;
            double discount = 1;
            double totalPrice = 0;

            if (accomodation == "room for one person")
            {
                accomodationPrice = 18;
            }
            else if (accomodation == "apartment")
            {
                accomodationPrice = 25;
                if (stay < 10)
                {
                    discount = 0.7;
                }
                else if (stay >= 10 && stay <= 15)
                {
                    discount = 0.65;
                }
                else if (stay > 15)
                {
                    discount = 0.5;
                }
            }
            else if (accomodation == "president apartment")
            {
                accomodationPrice = 35;
                if (stay < 10)
                {
                    discount = 0.9;
                }
                else if (stay >= 10 && stay <= 15)
                {
                    discount = 0.85;
                }
                else if (stay > 15)
                {
                    discount = 0.8;
                }
            }
            if (review == "positive")
            {
                totalPrice = accomodationPrice * stay * discount * 1.25;
            }
            else if (review == "negative")
            {
                totalPrice = accomodationPrice * stay * discount * 0.9;
            }
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
