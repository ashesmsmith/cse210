using System;
using System.IO;
using System.Collections.Generic;

// Hold and display the journal information as a whole

public class Journal
{
    public string _journalFile;

    public List<Entry> _entries = new List<Entry>();

    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveFile()
    {
        using (StreamWriter outputFile = new StreamWriter(_journalFile))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
            }  
        }
    }
    
    public void LoadFile()
    {
        string[] lines = System.IO.File.ReadAllLines(_journalFile);
        
        foreach (string line in lines)
        {
            Entry newEntry = new Entry();
            string[] parts = line.Split("|");

            newEntry._date = parts[0];
            newEntry._prompt = parts[1];
            newEntry._response = parts[2];

            _entries.Add(newEntry);
        }
    }
}