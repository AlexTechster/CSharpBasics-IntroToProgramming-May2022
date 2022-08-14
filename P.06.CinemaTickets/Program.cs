using System;

namespace P._06.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            double studentCount = 0;
            double standardCount = 0;
            double kidCount = 0;
            

            while (true)
            { 
                string movie = Console.ReadLine();

                if (movie == "Finish")
                {
                    break;
                }

                int freeTickets = int.Parse(Console.ReadLine());

                int ticketsSoldPerMovie = 0;
                double ticketsPercentage = 0.0;


                for (int i = freeTickets; i > 0; i--)
                {
                    string ticketType = Console.ReadLine();
                    
                    switch (ticketType)
                    {
                        case "student":
                            studentCount += 1;
                            ticketsSoldPerMovie++;
                            break;
                        case "standard":
                            standardCount += 1;
                            ticketsSoldPerMovie++;
                            break;
                        case "kid":
                            kidCount += 1;
                            ticketsSoldPerMovie++;
                            break;
                    }
                    if (ticketType == "End")
                    {
                        break;
                    }
                }

                ticketsPercentage = (double)ticketsSoldPerMovie / freeTickets * 100;
                total += ticketsSoldPerMovie;
                Console.WriteLine($"{movie} - {ticketsPercentage:f2}% full.");
            }
            studentCount = studentCount / total * 100;
            standardCount = standardCount / total * 100;
            kidCount = kidCount / total * 100;
            Console.WriteLine($"Total tickets: {total}");
            Console.WriteLine($"{studentCount:f2}% student tickets.");
            Console.WriteLine($"{standardCount:f2}% standard tickets.");
            Console.WriteLine($"{kidCount:f2}% kids tickets.");
        }
    }
}
