using System;

// Hold prompts and track number of answers user enters
// Display a random prompt

public class ListingActivity : Activity
{
    // ATTRIBUTES
    private int _totalAnswers;
    private List<string> _listPrompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    // CONSTRUCTORS
    public ListingActivity(string activity, string description) : base(activity, description)
    {
        
    }

    // METHODS
    public void DisplayListing()
    {
        DisplayStart();
        Spinner();

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine("");
        Console.WriteLine($"--- {GetListPrompt()} ---");
        Console.WriteLine("");
        Console.Write("You may begin in: 5");
        for (int i=4; i>-1; i=i-1)
        {
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write($"{i}");
        }

        Console.WriteLine("");

        // Start accepting answers from user
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_duration);
        DateTime current = DateTime.Now;

        while (current < end)
        {
            current = DateTime.Now; // Reset current time

            Console.Write("> ");
            Console.ReadLine();
            _totalAnswers += 1;
        }

        DisplayListEnd();
        DisplayEnd();
    }

    public string GetListPrompt()
    {
        Random random = new Random();
        int index = random.Next(_listPrompts.Count);

        return (_listPrompts[index]);
    }

    public void DisplayListEnd()
    {
        Console.WriteLine("");
        Console.WriteLine($"You listed {_totalAnswers} items!");
    }
}