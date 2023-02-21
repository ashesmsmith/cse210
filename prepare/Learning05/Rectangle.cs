using System;

public class Rectangle : Shape
{
    // ATTRIBUTES
    private float _length;
    private float _width;

    // CONSTRUCTORS
    public Rectangle (string color, float length, float width) : base (color)
    {
        _length = length;
        _width = width;
    }

    // METHODS
    public override double GetArea()
    {
        double area = _length * _width;
        return area;
    }
}