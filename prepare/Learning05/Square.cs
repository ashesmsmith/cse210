using System;

public class Square : Shape
{
    // ATTRIBUTES
    private float _side;

    // CONSTRUCTORS
    public Square (string color, float side) : base (color)
    {
        _side = side;
    }

    // METHODS
    public override double GetArea()
    {
        double area = _side * _side;
        return area;
    }
}