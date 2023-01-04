using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the grade percentage? ");
        string grade = Console.ReadLine();

        int numGrade = int.Parse(grade);
        string letter = "";

        if (numGrade >= 90)
        {
            //Console.WriteLine("The letter grade is A.");
            letter = "A";
        }

        else if (numGrade >= 80)
        {
            // Console.WriteLine("The letter grade is B.");
            letter = "B";
        }

        else if (numGrade >= 70)
        {
            // Console.WriteLine("The letter grade is C.");
            letter = "C";
        }

        else if (numGrade >= 60)
        {
            // Console.WriteLine("The letter grade is D.");
            letter = "D";
        }

        else
        {
            // Console.WriteLine("The letter grade is F.");
            letter = "F";
        }

        Console.WriteLine($"The letter grade is {letter}.");


        if (numGrade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry. You did not pass the class.");
        }
    }
}