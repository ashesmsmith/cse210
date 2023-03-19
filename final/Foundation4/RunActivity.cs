using System;

public class RunActivity : Activity
{
    // ATTRIBUTES
    private double _distance; // In miles

    // CONSTRUCTORS
    public RunActivity(string type, string date, double minutes, double distance) 
    : base(type, date, minutes)
    {
        _distance = distance;
    }

    // METHODS
    public override double CalculateDistance()
    {
        return Math.Round(_distance, 2);
    }

    public override double CalculateSpeed()
    {
        double speed = (_distance / _minutes) * 60;

        return Math.Round(speed, 2);
    }

    public override double CalculatePace()
    {
        double pace = 60 / CalculateSpeed();

        return Math.Round(pace, 2);
    }
}