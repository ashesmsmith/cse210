using System;

public class EternalGoal : Goal
{
    // ATTRIBUTES
    private int _timesCompleted;

    // CONSTRUCTORS
    public EternalGoal()
    {

    }
    
    public EternalGoal(string type) : base(type)
    {
        Console.Write("Enter a name for the goal: ");
        _goalTitle = Console.ReadLine();

        Console.Write("Enter the description for the goal: ");
        _goalDescription = Console.ReadLine();

        Console.Write("Enter the points associated with the goal: ");
        _goalPoints = int.Parse(Console.ReadLine());

        _timesCompleted = 0;
    }

    public EternalGoal(string type, string title, string description, int points, int completed) : base (type)
    {
        _goalType = type;
        _goalTitle = title;
        _goalDescription = description;
        _goalPoints = points;
        _timesCompleted = completed;
    }

    // METHODS
    public override string GetStringRepresentation()
    {
        string goalstring = ($"{_goalType}:{_goalTitle}|{_goalDescription}|{_goalPoints}|{_timesCompleted}");
        
        return goalstring;
    }

    public override void DisplayFormat(string details)
    {
        string[] parts = details.Split("|");

        string title = parts[0];
        string description = parts[1];
        string points = parts[2];
        string count = parts[3];

        Console.WriteLine($"[ ] {title} - {description} - Completed {count} times");
    }

    public override int RecordEvent()
    {
        _timesCompleted += 1;
        Console.WriteLine($"Congratulations! You earned {_goalPoints}!");

        return _goalPoints;
    }

    public override string IsComplete()
    {
        string complete = " ";

        return complete;
    }
}