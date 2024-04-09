using System;

namespace EventPlanning   // Replace YourNamespace with the actual namespace you are using
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Event, Lecture, Reception, and OutdoorGathering
            Event standardEvent = new Event("Generic Event", "Just a regular event", DateTime.Now, TimeSpan.FromHours(2), "123 Main St");

            Lecture lectureEvent = new Lecture("OOP Fundamentals", "Understanding object-oriented programming", DateTime.Now, TimeSpan.FromHours(2), "456 Oak St", "Mr. Christian Uche", 100);

            Reception receptionEvent = new Reception("Networking Mixer", "Casual networking event", DateTime.Now, TimeSpan.FromHours(3), "789 Pine St", "christianuche720@gmail.com");

            OutdoorGathering outdoorEvent = new OutdoorGathering("Summer BBQ", "Fun outdoor gathering", DateTime.Now, TimeSpan.FromHours(4), "101 Forest St", "Sunny");

            // Display event information
            Console.WriteLine("Standard Event Details:");
            Console.WriteLine(standardEvent.GetStandardDetails());

            Console.WriteLine("\nLecture Event Details:");
            Console.WriteLine(lectureEvent.GetFullDetails());

            Console.WriteLine("\nReception Event Details:");
            Console.WriteLine(receptionEvent.GetFullDetails());

            Console.WriteLine("\nOutdoor Gathering Event Details:");
            Console.WriteLine(outdoorEvent.GetFullDetails());
        }
    }
}