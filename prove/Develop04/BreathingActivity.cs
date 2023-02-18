using System;

// Derived Class of Activity
// Display the breathing activity

public class BreathingActivity : Activity
{
    // ATTRIBUTES

    // CONSTRUCTORS
    public BreathingActivity(string activity, string description): base (activity, description)
    {
        
    }

    // METHODS
    public void DisplayBreathing()
    {
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_durationDesired);
        DateTime current = DateTime.Now;

        while (current < end)
        {
            Console.Write($"Breathe in...4");
            for (int i=3; i>-1; i=i-1)
            {
                Thread.Sleep(1000);
                Console.Write("\b \b");
                Console.Write($"{i}");
            }
            Console.WriteLine("");

            Console.Write($"Breathe out...6");
            for (int i=5; i>-1; i=i-1)
            {
                Thread.Sleep(1000);
                Console.Write("\b \b");
                Console.Write($"{i}");
            }
            Console.WriteLine("");

            current = DateTime.Now; // Reset current time
            Console.WriteLine("");
        }
    }
}