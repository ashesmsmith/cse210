using System;

public class Comment
{
    // ATTRIBUTES
    private string _name;
    private string _text;

    // CONSTRUCTORS
    public Comment(string name, string text)
    {
        _name= name;
        _text = text;
    }

    // METHODS
    public void DisplayComment()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Comment: {_text}");
    }
}