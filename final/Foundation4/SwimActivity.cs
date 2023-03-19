using System;

public class SwimActivity : Activity
{
    // ATTRIBUTES
    private int _laps; // 50 meters per lap

    // CONSTRUCTORS
    public SwimActivity(string type, string date, double minutes, int laps) 
    : base(type, date, minutes)
    {
        _laps = laps;
    }

    // METHODS
    public override double CalculateDistance()
    {
        double distance = _laps * 50 / 1000 * 0.62;

        return Math.Round(distance, 2);
    }

    public override double CalculateSpeed()
    {
        double speed = (CalculateDistance() / _minutes) * 60;

        return Math.Round(speed, 2);
    }

    public override double CalculatePace()
    {
        double pace = 60 / CalculateSpeed();

        return Math.Round(pace, 2);
    }
}