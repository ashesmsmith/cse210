using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Blue", 5);
        Console.WriteLine($"Square Color: {square.GetColor()}");
        Console.WriteLine($"Square Area: {square.GetArea()}");

        shapes.Add(square);
        Console.WriteLine("");

        Rectangle rectangle = new Rectangle("Red", 6, 8);
        Console.WriteLine($"Rectangle Color: {rectangle.GetColor()}");
        Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");

        shapes.Add(rectangle);
        Console.WriteLine("");

        Circle circle = new Circle("Yellow", 7);
        Console.WriteLine($"Circle Color: {circle.GetColor()}");
        Console.WriteLine($"Circle Area: {circle.GetArea()}");

        shapes.Add(circle);
        Console.WriteLine("");

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"Color: {color} Area: {area}");
        }        
    }
}