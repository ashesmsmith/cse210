using System;

public abstract class Shape
{
    // ATTRUBUTES
    private string _color;

    // CONSTRUCTORS
    public Shape(string color)
    {
       _color = color;
    }

    // METHODS
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    // public virtual double GetArea()
    // {
    //     return 0;
    // }

    public abstract double GetArea();
}