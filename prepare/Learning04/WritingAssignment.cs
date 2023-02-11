using System;

public class WritingAssignment : Assignment
{
    // ATTRIBUTES
    private string _title;


    // CONSTRUCTORS
    public WritingAssignment (string name, string topic, string title) : base (name, topic)
    {
        _title = title;
    }


    // METHODS
    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
}