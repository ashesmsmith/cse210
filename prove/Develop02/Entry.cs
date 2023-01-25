using System;

// Hold and display information needed for an individual journal entry

public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    public void DisplayEntry()
    {
        Console.WriteLine("");
        Console.WriteLine($"{_date}: {_prompt}");
        Console.WriteLine($"{_response}");
    }
}