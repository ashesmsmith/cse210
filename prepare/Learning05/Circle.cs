using System;

public class Circle : Shape
{
    // ATTRIBUTES
    private float _radius;

    // CONSTRUCTORS
    public Circle (string color, float radius) : base (color)
    {
        _radius = radius;
    }

    // METHODS
    public override double GetArea()
    {
        double area = Math.PI * (_radius * _radius);
        return area;
    }
}