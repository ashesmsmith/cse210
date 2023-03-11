using System;

public class Goal
{
    // ATTRIBUTES
    protected string _goalType;
    protected string _goalTitle;
    protected string _goalDescription;
    protected int _goalPoints;

    // CONSTRUCTORS
    public Goal()
    {

    }
    public Goal(string type)
    {
        _goalType = type;
    }

    // METHODS
    public virtual string GetStringRepresentation() // Overridden by derived classes
    {
        string goalstring = ($"{_goalType}:{_goalTitle}|{_goalDescription}|{_goalPoints}");
        
        return goalstring;
    }

    public virtual void DisplayFormat(string details) // Overridden by derived classes
    {
        
    }

    public virtual int RecordEvent() // Overridden by derived classes
    {
        return _goalPoints;
    }

    public virtual string IsComplete() // Overridden by derived classes
    {
        string complete = " ";
        return complete;
    }

    public void DisplayAll(List<Goal> goals) // Display All goals from list in Program
    {
        Console.WriteLine("");
        Console.WriteLine("The goals are: ");

        int index = 0;

        foreach (Goal goal in goals)
        {
            string goalline = goal.GetStringRepresentation(); // Convert from Goal to string
            string[] lineparts = goalline.Split(":"); // Seperate the type from the details

            string type = lineparts[0];
            string details = lineparts[1];
            index = index + 1;
            
            Console.Write($"{index}. ");

            if (type == "SimpleGoal") // Display Format for SimpleGoals
            {
                SimpleGoal display = new SimpleGoal();
                display.DisplayFormat(details);
            }

            else if (type == "EternalGoal") // Display Format for EternalGoals
            {
                EternalGoal display = new EternalGoal();
                display.DisplayFormat(details);
            }

            else if (type == "ChecklistGoal") // Display Format for ChecklistGoals
            {
                ChecklistGoal display = new ChecklistGoal();
                display.DisplayFormat(details);
            }
        }
    }
}