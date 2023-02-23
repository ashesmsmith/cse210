using System;

// Derived Class of Activity
// Display the grounding activity

public class GroundingActivity : Activity
{
    // ATTRIBUTES
    // No additional attributes needed

    // CONSTRUCTORS
    public GroundingActivity(string activity, string description) : base (activity, description)
    {

    }
    
    // METHODS
    public void DisplayGrounding()
    {
        DisplayStart();
        Spinner();

        int pause = (_duration / 5) * 1000;

        Console.WriteLine("Focus on finding things around you for each prompt.");
        Spinner();

        Console.WriteLine("--- 5 things you can SEE ---");
        Thread.Sleep(pause);

        Console.WriteLine("--- 4 things you can TOUCH ---");
        Thread.Sleep(pause);

        Console.WriteLine("--- 3 things you can HEAR ---");
        Thread.Sleep(pause);

        Console.WriteLine("--- 2 things you can SMELL ---");
        Thread.Sleep(pause);

        Console.WriteLine("--- 1 thing you can TASTE ---");
        Thread.Sleep(pause);

        DisplayEnd();
    }
}