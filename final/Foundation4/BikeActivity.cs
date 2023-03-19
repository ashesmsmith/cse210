using System;

public class BikeActivity : Activity
{
    // ATTRIBUTES
    private double _speed; // miles per hour

    // CONSTRUCTORS
    public BikeActivity(string type, string date, double minutes, double speed) 
    : base(type, date, minutes)
    {
        _speed = speed;
    }

    // METHODS
    public override double CalculateDistance()
    {
        double distance = _speed * _minutes;

        return Math.Round(distance, 2);
    }

    public override double CalculateSpeed()
    {
        return Math.Round(_speed, 2);
    }

    public override double CalculatePace()
    {
        double pace = 60 / _speed;

        return Math.Round(pace, 2);
    }
}