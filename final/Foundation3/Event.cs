using System;

public class Event
{
    // ATTRIBUTES
    protected string _type;
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;

    // CONSTRUCTORS
    public Event(string type, string title, string description, 
    string date, string time, string street, string city, string state, 
    int zip, string country)
    {
        _type = type;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        
        Address address  = new Address(street, city, state, zip, country);
        _address = address.GetAddressString();
    }

    // METHODS
    public void DisplayStandardMessage()
    {
        Console.WriteLine($"{_title} \n{_description}");
        Console.WriteLine($" \n{_date} {_time} \n{_address}");
    }

    public virtual void DisplayFullMessage()
    {
        Console.WriteLine($"{_title} \n{_description} \n{_date} {_time} \n{_address}");
    }

    public void DisplayShortMessage()
    {
        Console.WriteLine($"{_type}: {_title} - {_date}");
    }
}