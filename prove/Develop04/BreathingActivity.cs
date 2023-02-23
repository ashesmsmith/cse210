using System;

// Derived Class of Activity
// Display the breathing activity

public class BreathingActivity : Activity
{
    // ATTRIBUTES
    // No additional attributes needed

    // CONSTRUCTORS
    public BreathingActivity(string activity, string description): base (activity, description)
    {
        
    }

    // METHODS
    public void DisplayBreathing()
    {
        DisplayStart();
        Spinner();

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_duration);
        DateTime current = DateTime.Now;

        while (current < end)
        {
            Console.WriteLine("");
            Console.Write($"Breathe in...4");
            for (int i=3; i>-1; i=i-1)
            {
                Thread.Sleep(1000);
                Console.Write("\b \b");
                Console.Write($"{i}");
            }
            Console.Write("\b \b");

            Console.WriteLine("");
            Console.Write($"Breathe out...6");
            for (int i=5; i>-1; i=i-1)
            {
                Thread.Sleep(1000);
                Console.Write("\b \b");
                Console.Write($"{i}");
            }
            Console.Write("\b \b");

            current = DateTime.Now; // Reset current time
            Console.WriteLine("");
        }

        DisplayEnd();
    }
}