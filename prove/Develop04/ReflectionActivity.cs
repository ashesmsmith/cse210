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
        DisplayPrompt();
        Console.Clear();
        DisplayQuestions();
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
        DateTime end = start.AddSeconds(_durationDesired);
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



// NOT USING - BROKEN - DIDN'T WORK

    //  private string _question;
    //  private bool _used = false; // Default - question has not been asked

    // public void SetQuestion() // DUPLICATE PROMPTS RETURNED
    // {
    //     int index = 0;
    //     string end = Continue();

    //     do
    //     {
    //         Random random = new Random();
    //         index = random.Next(_questions.Count);
    //         end = Continue();

    //         if (end == "STOP") // Question has been asked. Pick again.
    //         {
    //             break;
    //         } 

    //     } while (_questions[index].GetUsed());      

    //     if (end != "STOP")
    //     {
    //         string question = _questions[index];
    //     }

    // }


    // public void SetUsed()
    // {
    //     _used = true;
    // }
    

    // public bool GetUsed()
    // {
    //     return _used;
    // }


    // public string Continue() // If the question has been asked return "STOP"
    // {
    //     string end = "STOP";

    //     foreach (string question in _questions)
    //     {
    //         if (GetUsed() == false) // Question has not been asked
    //         {
    //             end = "";
    //         }
    //     }

    //     return end;
    // }


    // public void SetQuestion()
    // {
    //     Random random = new Random();
    //     int index = random.Next(_questions.Count);

    //     _question = _questions[index];

    //     if (_used == false)
    //     {
    //         _used = true;
    //     }

    //     else
    //     {
    //         SetQuestion();
    //     }
    // }


    // public void DisplayReflection() // DISPLAYING DUPLICATE QUESTIONS
    // {
    //     Console.WriteLine(GetReflectPrompt());
    //     Console.WriteLine("");
    //     Thread.Sleep(5000);

    //     DateTime start = DateTime.Now;
    //     DateTime end = start.AddSeconds(_durationDesired);
    //     DateTime current = DateTime.Now;

    //     while (current < end)
    //     {
    //         SetQuestion();
    //         Console.WriteLine(_question);
    //         Spinner();
    //         Console.WriteLine("");

    //         current = DateTime.Now;
    //     }
    // }