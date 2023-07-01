using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("123 Main St", "New York", "NY", "10001");
        Address receiptionAddress = new Address("456 Central Ave", "Los Angeles", "CA", "90001");
        Address outdoorGatheringAddress = new Address("789 Park Blvd", "Chicago", "IL", "60601");

        Lecture lecture = new Lecture("Lecture on Programming", "A discussion on the latest advancements in Programming", new DateTime(2023, 4, 10), new TimeSpan(18, 00, 00), lectureAddress, "Dr. John Doe", 100);
        Reception reception = new Reception("Networking Event", "Join us for a networking event with professionals from various industries", new DateTime(2023, 4, 15), new TimeSpan(19, 00, 00), receiptionAddress, "rsvp@example.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Outdoor Yoga Session", "A relaxing yoga session in the park", new DateTime(2023, 4, 20), new TimeSpan(9, 00 , 00), outdoorGatheringAddress, "Sunny, with a high of 75F");

        Event[] events = new Event[] { lecture, reception, outdoorGathering };

        foreach (Event eventInstance in events)
        {
            System.Console.WriteLine("Standard Details:\n" + eventInstance.GetStandardDetails());
            System.Console.WriteLine("\nFull Details:\n" + eventInstance.GetFullDetails());
            System.Console.WriteLine("\nShort Description:\n" + eventInstance.GetShortDescription());
            System.Console.WriteLine("\n------------------------------------\n"); 
        }
    }
}