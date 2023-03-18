using System;

public class OutdoorEvent : Event
{
    // ATTRIBUTES
    private string _weather;

    // CONSTRUCTORS
    public OutdoorEvent(string type, string title, string description, 
    string date, string time, string street, string city, string state, 
    int zip, string country, string weather)
    : base (type, title, description, date, time, street, city, state, zip, country)
    {
        _weather = weather;
    }

    // METHODS
    public override void DisplayFullMessage()
    {
        Console.WriteLine($"{_title} \n{_description}");
        Console.WriteLine("");
        Console.WriteLine($"{_date} {_time} \n{_address}");
        Console.WriteLine("");
        Console.WriteLine($"The weather is forecasted to be {_weather}.");
    }
}