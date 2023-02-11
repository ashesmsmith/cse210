using System;
using System.Collections.Generic;

// Hold information for the scripture display

class Scripture
{
    // ATTRIBUES
    // private string _reference;
    private Reference _reference;
    private List<Word> _verseWords;

    // CONSTRUCTOR
    public Scripture(string text)
    {
        _verseWords = new List<Word>();
        string[] splitText = text.Split(" ");

        foreach (string word in splitText)
        {
            Word addWord = new Word(word);
            _verseWords.Add(addWord);
        }              
    }

    // METHODS
    public void SetReference(Reference reference)
    {
        _reference = reference;
    }

    public void Display()
    {
        Console.WriteLine(_reference.DisplayReference());

        string verse = "";
        foreach (Word word in _verseWords)
        {
            verse = verse + " " + word.GetWord();
        }
        Console.WriteLine(verse);
        Console.WriteLine("");
    }

    public void HideWord()
    {
        int index = 0;
        string end = Continue();

        do
        {
            Random random = new Random();
            index = random.Next(_verseWords.Count); // Pick a random index
            end = Continue();

            if (end == "STOP") // Word is hidden pick new random index
            {
                break;
            }

        } while (_verseWords[index].GetHidden());


        if (end != "STOP")
        {
            string hideWord = _verseWords[index].GetWord();

            Word hide = new Word(hideWord);
            hide.HideWord(); // Set to hidden and change word to _'s
            _verseWords[index] = hide; // Replace the word in the list
        }
    }

    public string Continue() // If the word is already hidden return "STOP"
    {
        string end = "STOP";

        foreach (Word word in _verseWords)
        {
            if (word.GetHidden() == false) // word is not hidden
            {
                end = "";
            }
        }

        return end;
    }

    public int Max() // Max times the program can run
    {
        int max = _verseWords.Count();
        return max;
    }
}