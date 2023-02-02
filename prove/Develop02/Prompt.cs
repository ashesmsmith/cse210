using System;
using System.Collections.Generic;

// Hold and display the information needed for a random prompt selection
// Used with class Entry, the random prompt will be stored as string _prompt

public class Prompt
{    
    public List<string> _prompts = new List<string>()
    {
        "What was the best part of my day?", 
        "Who was the most interesting person I interacted with today?",
        "If I could do over today, what would would I change?",
        "What did I do for someone else today?",
        "What is a miracle I recognized today?"
    };

    public string DisplayPrompt()
    {        
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        
        return (_prompts[index]);
    }
}