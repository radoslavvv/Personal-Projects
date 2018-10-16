using System;

namespace Problem05
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter days count: ");
            int daysCount = int.Parse(Console.ReadLine());

            int bankersCount = 7;

            int totalSeenClients = 0;
            int totalSentAwayClients = 0;

            int seenClients = 0;
            int sentAwayClients = 0;
            for (int i = 1; i <= daysCount; i++)
            {
                Console.Write("Today's customers count: ");
                int clientsCount = int.Parse(Console.ReadLine());


                // if the day is 3rd and the sent away are more than the seen 
                if (i % 3 == 0 && sentAwayClients > seenClients)
                {
                    // one banker is added
                    bankersCount++;

                    // the total clients counters are increased
                    totalSeenClients += seenClients;
                    totalSentAwayClients += sentAwayClients;

                    // current 3 day period counters are cleared
                    sentAwayClients = 0;
                    seenClients = 0;
                }

                int seenClientsToday = 0;
                int sentAwayClientsToday = 0;

                if (clientsCount > bankersCount)
                {
                    seenClients += bankersCount;
                    sentAwayClients += clientsCount - bankersCount;

                    seenClientsToday = bankersCount;
                    sentAwayClientsToday = clientsCount - bankersCount;
                }
                else
                {
                    seenClients += clientsCount;

                    seenClientsToday = clientsCount;
                }

                Console.WriteLine($"Today's seen clients: {seenClientsToday}");
                Console.WriteLine($"Today's sent away clients: {sentAwayClientsToday}");
            }

            totalSeenClients += seenClients;
            totalSentAwayClients += sentAwayClients;

            Console.WriteLine($"Total seen clients: {totalSeenClients}");
            Console.WriteLine($"Total sent away clients: {totalSentAwayClients}");
        }
    }
}
