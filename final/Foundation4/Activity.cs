using System;

public class Activity
{
    // ATTRIBUTES
    private string _type;
    private string _date;
    protected double _minutes;

    // CONSTRUCTORS
    public Activity(string type, string date, double minutes)
    {
        _type = type;
        _date = date;
        _minutes = minutes;
    }

    // METHODS
    public virtual double CalculateDistance()
    {
        double distance = 0;

        return distance;
    }

    public virtual double CalculateSpeed()
    {
        double speed = 0;

        return speed;
    }

    public virtual double CalculatePace()
    {
        double pace = 0;

        return pace;
    }

    public void GetSummary()
    {
        Console.Write($"· {_date} {_type} ({_minutes} min) - " +
        $"Distance: {CalculateDistance()} miles, Speed: {CalculateSpeed()} mph, "+
        $"Pace: {CalculatePace()} min per mile");
    }
}