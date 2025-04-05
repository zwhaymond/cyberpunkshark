using System;

class Program
{
    static void Main(string[] args)
    {
        Address eventAddress1 = new Address("123 Main St", "New York", "NY", "10001");
        Address eventAddress2 = new Address("456 Oak Ave", "Los Angeles", "CA", "90001");
        Address eventAddress3 = new Address("789 Pine Rd", "San Francisco", "CA", "94101");

        Lecture lecture = new Lecture("Tech Innovations", "A lecture on the latest in tech.", new DateTime(2025, 5, 15), "10:00 AM", eventAddress1, "Dr. Jane Smith", 100);
        Reception reception = new Reception("Summer Gala", "A reception to celebrate the summer season.", new DateTime(2025, 6, 20), "6:00 PM", eventAddress2, "rsvp@summergala.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Beach Cleanup", "Join us to clean the beach and protect the environment.", new DateTime(2025, 7, 10), "9:00 AM", eventAddress3, "Sunny with a chance of clouds");

        Event[] events = { lecture, reception, outdoorGathering };

        foreach (var e in events)
        {
            Console.WriteLine("Standard Details:");
            Console.WriteLine(e.StandardDetails());
            Console.WriteLine();

            Console.WriteLine("Full Details:");
            Console.WriteLine(e.FullDetails());
            Console.WriteLine();

            Console.WriteLine("Short Description:");
            Console.WriteLine(e.ShortDescription());
            Console.WriteLine("------------------------------------");
        }
    }
}
