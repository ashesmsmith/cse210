using System;

public class Assignment
{
    //ATTRIBUTES
    private string _studentName;
    private string _topic;


    //CONSTRUCTORS
    public Assignment (string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }


    //METHODS
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    public string GetStudentName()
    {
        return _studentName;
    }
}