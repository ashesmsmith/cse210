using System;

public class LectureEvent : Event
{
    // ATTRIBUTES
    private string _speaker;
    private int _capacity;

    // CONSTRUCTORS
    public LectureEvent(string type, string title, string description, 
    string date, string time, string street, string city, string state, 
    int zip, string country, string speaker, int capacity)
    : base (type, title, description, date, time, street, city, state, zip, country)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    // METHODS
    public override void DisplayFullMessage()
    {
        Console.WriteLine($"{_title} \n{_description}");
        Console.WriteLine("");
        Console.WriteLine($"{_date} {_time} \n{_address}");
        Console.WriteLine("");
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Maxium Capacity: {_capacity}");
    }
}