using System;

// Hold prompts and questions for Reflection Activity
// Display random prompt and questions

public class ReflectionActivity : Activity
{
    // ATTRIBUTES
    private List<string> _reflectPrompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    // CONSTRUCTORS
    public ReflectionActivity(string activity, string description) : base(activity, description)
    {
        
    }

    // METHODS
    public void DisplayReflection()
    {
        DisplayStart();
        Spinner();

        DisplayPrompt();
        Console.Clear();
        DisplayQuestions();

        DisplayEnd();
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine("");
        Console.WriteLine($"--- {GetReflectPrompt()} ---");
        Console.WriteLine("");
        Console.Write("When you have something in mind, press ENTER to continue. ");
        Console.ReadLine();

        Console.WriteLine("");
        Console.WriteLine("Now ponder on each of the following questions " +
        "as they related to this experience.");

        Console.Write("You may begin in: 5");
        for (int i=4; i>-1; i=i-1)
        {
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write($"{i}");
        }
    }

    public void DisplayQuestions() // CURRENTLY DISPLAYING DUPLICATE QUESTIONS
    {
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_duration);
        DateTime current = DateTime.Now;

        while (current < end)
        {
            Console.Write($"> {GetQuestion()} ");
            Spinner();

            current = DateTime.Now; // Reset current time
        }
    }

    public string GetReflectPrompt() // Choose a random prompt from list
    {
        Random random = new Random();
        int index = random.Next(_reflectPrompts.Count);

        return (_reflectPrompts[index]);
    }

    public string GetQuestion() // Choose a random question from list
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);

        return (_questions[index]);
    } 
}