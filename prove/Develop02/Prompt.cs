using System;
using System.Collections.Generic;

// Hold and display the information needed for a random prompt selection
// Used with class Entry, the random prompt will be stored as string _prompt

public class Prompt
{
    public string _prompt1 = "Who was the most interesting person I interacted with today?";
    public string _prompt2 = "What was the best part of my day?";
    public string _prompt3 = "If I could do over today, what would would I change?";
    public string _prompt4 = "What did I do for someone else today?";
    public string _prompt5 = "What is a miracle I recognized today?";
    
    public List<string> _prompts = new List<string>();

    public string DisplayPrompt()
    {        
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        
        return (_prompts[index]);
    }
}