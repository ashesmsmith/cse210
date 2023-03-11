using System;

public class ChecklistGoal : Goal
{
    // ATTRIBUTES
    private int _completed;
    private int _required;
    private int _goalBonus;

    // CONSTRUCTORS
    public ChecklistGoal()
    {

    }
    
    public ChecklistGoal(string type) : base(type)
    {
        Console.Write("Enter a name for the goal: ");
        _goalTitle = Console.ReadLine();

        Console.Write("Enter the description for the goal: ");
        _goalDescription = Console.ReadLine();

        Console.Write("Enter the points associated with the goal: ");
        _goalPoints = int.Parse(Console.ReadLine());

        _completed = 0;

        Console.Write("How many times does this goal need to be accomplished? ");
        _required = int.Parse(Console.ReadLine());

        Console.Write("Enter the bonus points awarded when completed: ");
        _goalBonus = int.Parse(Console.ReadLine());

        
    }

    public ChecklistGoal(string type, string title, string description, int points, int completed, int required, int bonus) : base (type)
    {
        _goalType = type;
        _goalTitle = title;
        _goalDescription = description;
        _goalPoints = points;
        _completed = completed;
        _required = required;
        _goalBonus = bonus;
    }

    // METHODS
    public override string GetStringRepresentation()
    {
        string goalstring = ($"{_goalType}:{_goalTitle}|{_goalDescription}|{_goalPoints}|{_completed}|{_required}|{_goalBonus}");
        
        return goalstring;
    }

    public override void DisplayFormat(string details)
    {
        string[] parts = details.Split("|");

        string title = parts[0];
        string description = parts[1];
        string points = parts[2];
        int completed = int.Parse(parts[3]);
        int required = int.Parse(parts[4]);
        string bonus = parts[5];

        string complete = " ";
        
        if (completed >= required)
        {
            complete = "X";
        }

        Console.WriteLine($"[{complete}] {title} - {description} - Completed {completed}/{required} times");
    }

    public override int RecordEvent()
    {
        _completed += 1;

        int points = _goalPoints;

        if (_completed == _required)
        {
            Console.WriteLine($"You earned {_goalBonus} bonus points!");
            points = points + _goalBonus;
        }

        Console.WriteLine($"Congratulations! You earned {points}!");

        return points;
    }

    public override string IsComplete()
    {
        string complete = " ";
        if (_completed >= _required)
        {
            complete = "X";
        }

        return complete;
    }
}