using System;

public class ReceiptionEvent : Event
{
    // ATTRIBUTES
    private string _email;

    // CONSTRUCTORS
    public ReceiptionEvent(string type, string title, string description, 
    string date, string time, string street, string city, string state, 
    int zip, string country, string email)
    : base (type, title, description, date, time, street, city, state, zip, country)
    {
        _email = email;
    }

    // METHODS
    public override void DisplayFullMessage()
    {
        Console.WriteLine($"{_title} \n{_description}");
        Console.WriteLine("");
        Console.WriteLine($"{_date} {_time} \n{_address}");
        Console.WriteLine("");
        Console.WriteLine($"Please RSVP to {_email}.");
    }
}