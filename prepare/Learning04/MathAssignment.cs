using System;

public class MathAssignment : Assignment
{
    // ATTRIBUTES
    private string _textBookSection;
    private string _problems;


    // CONSTRUCTORS
    public MathAssignment(string name, string topic, string section, string problems) : base (name, topic)
    {
        _textBookSection = section;
        _problems = problems;
    }


    // METHODS
    public string GetHomework()
    {
        return $"Section {_textBookSection} Problems {_problems}";
    }
}