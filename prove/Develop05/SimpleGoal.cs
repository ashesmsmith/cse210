using System;

public class SimpleGoal : Goal
{
    // ATTRIBUTES
    private bool _completed;

    // CONSTRUCTORS
    public SimpleGoal()
    {

    }
    
    public SimpleGoal(string type) : base(type)
    {
        Console.Write("Enter a name for the goal: ");
        _goalTitle = Console.ReadLine();

        Console.Write("Enter the description for the goal: ");
        _goalDescription = Console.ReadLine();

        Console.Write("Enter the points associated with the goal: ");
        _goalPoints = int.Parse(Console.ReadLine());

        _completed = false;
    }

    public SimpleGoal(string type, string title, string description, int points, bool completed) : base (type)
    {
        _goalType = type;
        _goalTitle = title;
        _goalDescription = description;
        _goalPoints = points;
        _completed = completed;
    }

    // METHODS
    public override string GetStringRepresentation()
    {
        string goalstring = ($"{_goalType}:{_goalTitle}|{_goalDescription}|{_goalPoints}|{_completed}");
        
        return goalstring;
    }

    public override void DisplayFormat(string details)
    {
        string[] parts = details.Split("|");

        string title = parts[0];
        string description = parts[1];
        string points = parts[2];
        string completed = parts[3];

        string complete = " ";
        
        if (completed == "True")
        {
            complete = "X";
        }

        Console.WriteLine($"[{complete}] {title} - {description}");
    }

    public override int RecordEvent()
    {
        _completed = true;
        Console.WriteLine($"Congratulations! You earned {_goalPoints}!");

        return _goalPoints;
    }

    public override string IsComplete()
    {
        string complete = " ";
        if (_completed == true)
        {
            complete = "X";
        }
        return complete;
    }
}