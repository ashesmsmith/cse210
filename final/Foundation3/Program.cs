using System;

class Program
{
    static void Main(string[] args)
    {
        // Lecture Event with all display options
        LectureEvent levent = new LectureEvent("Lecture", "C# for Beginners", 
        "This lecture will discuss the basics of programming in C#.", "March 22nd, 2023",
        "6:00 PM", "123 This Street", "That City", "ID", 98765, "USA",
        "John Doe", 100);
        Console.WriteLine("\nStanard Message:");
        levent.DisplayStandardMessage();
        Console.WriteLine("\nShort Message:");
        levent.DisplayShortMessage();
        Console.WriteLine("\nFull Message:");
        levent.DisplayFullMessage();

        // Receiption Event with all display options
        ReceiptionEvent revent = new ReceiptionEvent("Reception", "John & Jane Doe",
        "A Receiption in celebration of John and Jane Doe.", "June 1, 2023", "7:00 PM",
        "456 That Drive", "This City", "ID", 65432, "USA", "rsvpemail@server.com");
        Console.WriteLine("\nStanard Message:");
        revent.DisplayStandardMessage();
        Console.WriteLine("\nShort Message:");
        revent.DisplayShortMessage();
        Console.WriteLine("\nFull Message:");
        revent.DisplayFullMessage();

        // Outdoor Event with all display options
        OutdoorEvent oevent = new OutdoorEvent("Outdoor", "This Park Annual Easter Egg Hunt",
        "The 5th Annual Easter Egg Hunt for This Park.", "April 9th, 2023", "12:00 PM",
        "789 This Parkway", "There", "ID", 12345, "USA", "sunny");
        Console.WriteLine("\nStanard Message:");
        oevent.DisplayStandardMessage();
        Console.WriteLine("\nShort Message:");
        oevent.DisplayShortMessage();
        Console.WriteLine("\nFull Message:");
        oevent.DisplayFullMessage();

        Console.WriteLine("");
    }
}