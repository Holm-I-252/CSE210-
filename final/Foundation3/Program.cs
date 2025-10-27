using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lectureEvent = new Lecture(
            "The Future of AI",
            "An in-depth look at the advancements in artificial intelligence.",
            new DateTime(2025, 10, 15),
            new DateTime(2025, 10, 15, 14, 0, 0),
            "123 Tech Avenue, Silicon Valley, CA",
            "Dr. Jane Smith",
            150
        );

        Reception receptionEvent = new Reception(
            "Networking Gala",
            "An evening of networking and socializing with industry professionals.",
            new DateTime(2025, 11, 20),
            new DateTime(2025, 11, 20, 19, 0, 0),
            "456 Event Plaza, New York, NY",
            "rsvp@networkinggala.com"
        );

        Outdoor outdoorEvent = new Outdoor(
            "Park Concert",
            "A free concert in the park featuring local artists.",
            new DateTime(2025, 12, 5),
            new DateTime(2025, 12, 5, 15, 0, 0),
            "789 Park Lane, Los Angeles, CA",
            "Sunny"
        );
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine(outdoorEvent.GetFullDetails());

        Console.WriteLine(lectureEvent.GetShortDescription());
        Console.WriteLine(receptionEvent.GetShortDescription());
        Console.WriteLine(outdoorEvent.GetShortDescription());

        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine(outdoorEvent.GetStandardDetails());
    }
}