using System;

class Program
{
    static void Main(string[] args)
    {
        // TESTING ASSIGNMENT CLASS
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine("");

        // TESTING MATHASSIGNMENT CLASS
        MathAssignment math1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomework());
        Console.WriteLine("");

        // TESTING WRITINGASSIGNMENT CLASS
        WritingAssignment write1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(write1.GetSummary());
        Console.WriteLine(write1.GetWritingInformation());
        Console.WriteLine("");
    }
}