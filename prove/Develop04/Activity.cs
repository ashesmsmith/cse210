using System;

// Base/Parent Class
// Hold all shared attributes and methods for activities

public class Activity
{
    //ATTRIBUTES
    private string _activityName;
    private string _description;
    protected int _durationDesired;

    // CONSTRUCTORS
    public Activity(string activity, string description)
    {
        _activityName = activity;
        _description = description;
    }

    //METHODS
    public void DisplayStart() // Attributes set in constructor
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");  

        SetDuration();
    }

    public void SetDuration() // Set the desired duration for the activity in seconds
    {
        Console.Write("How long, in seconds, would yo like for your session? ");
        int duration = int.Parse(Console.ReadLine());

        _durationDesired = duration;
    }

    public void Spinner()
    {
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(5);
        DateTime current = DateTime.Now;

        while (current < end)
        {
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");

            current = DateTime.Now;
        }

        Console.WriteLine("");
    }

    public void DisplayEnd()
    {
        Console.WriteLine("Well Done!");
        Spinner();

        Console.WriteLine($"You have completed {_durationDesired} seconds of the {_activityName}.");
        Spinner();
    }
}