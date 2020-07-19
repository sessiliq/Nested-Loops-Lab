namespace CinemaTickets
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double standardTickets = 0;
            double kidsTickets = 0;
            double studentsTickets = 0;

            while (true)
            {
                string movie = Console.ReadLine();
                if (movie == "Finish")
                {
                    break;
                }

                double freePlaces = double.Parse(Console.ReadLine());

                int i = 0;
                while (true)
                {
                    string typeOfTicket = Console.ReadLine();

                    if (typeOfTicket == "student")
                    {
                        studentsTickets += 1;
                    }
                    else if (typeOfTicket == "standard")
                    {
                        standardTickets += 1;
                    }
                    else if (typeOfTicket == "kid")
                    {
                        kidsTickets += 1;
                    }

                    if (typeOfTicket == "End" || ++i >= freePlaces)
                    {
                        break;
                    }
                }

                double percentTakenPlaces = (i / freePlaces) * 100;
                Console.WriteLine($"{movie} - {percentTakenPlaces:F2}% full.");
            }

            double totalTickets = studentsTickets + standardTickets + kidsTickets;

            double percentStudentsTickets = (studentsTickets / totalTickets) * 100;
            double percentStandartTickets = (standardTickets / totalTickets) * 100;
            double percentKidsTickets = (kidsTickets / totalTickets) * 100;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{percentStudentsTickets:F2}% student tickets.");
            Console.WriteLine($"{percentStandartTickets:F2}% standard tickets.");
            Console.WriteLine($"{percentKidsTickets:F2}% kids tickets.");
        }
    }
}
