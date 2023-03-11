using System;
using System.IO;

public class SaveLoad
{
    // ATTRIBUTES
    private string _filename;

    // CONSTRUCTORS
    public SaveLoad(string filename)
    {
        _filename = filename;
    }

    // METHODS
    public void SaveFile(List<Goal> list)
    {
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            foreach (Goal goal in list)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine($"The goals have been saved to file: {_filename}");
    }

    public (List<Goal>, int score) LoadFile()
    {
        string[] fileLines = System.IO.File.ReadAllLines(_filename);

        List<Goal> goals = new List<Goal>();
        int score = 0;

        foreach (string line in fileLines)
        {
            string[] parts = line.Split(":");
            string type = parts[0];
            string details = parts[1];

            string[] detailspart = details.Split("|");
            string title = detailspart[0];
            string description = detailspart[1];
            int points = int.Parse(detailspart[2]);

            if (type == "SimpleGoal")
            {
                bool completed = bool.Parse(detailspart[3]);

                SimpleGoal sload = new SimpleGoal(type, title, description, points, completed);
                goals.Add(sload);

                if (sload.IsComplete() == "X")
                {
                    score = score + points;
                }
            }

            if (type == "EternalGoal")
            {
                int timesComplete = int.Parse(detailspart[3]);

                EternalGoal eload = new EternalGoal(type, title, description, points, timesComplete);
                goals.Add(eload);
                score = score + (points * timesComplete);
            }

            if (type == "ChecklistGoal")
            {
                int completed = int.Parse(detailspart[3]);
                int required = int.Parse(detailspart[4]);
                int bonus = int.Parse(detailspart[5]);

                ChecklistGoal cload = new ChecklistGoal(type, title, description, points, completed, required, bonus);
                goals.Add(cload);
                score = score + (points * completed);

                if (cload.IsComplete() == "X")
                {
                    score = score + bonus;
                }
            }
        }

        return (goals, score);
    }
}