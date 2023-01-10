using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list and allow user to add numbers to it
        List<int> numbers = new List<int>();
        int number = -1;

        while (number != 0)
        {
            Console.Write("Please enter a number (enter 0 to stop): ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        // Find the sum of the numbers in the list
        Console.WriteLine($"The sum is: {numbers.Sum()}.");

        // Find the average of the numbers in the list
        Console.WriteLine($"The average is: {numbers.Average()}");

        // Find the largest number in the list
        Console.WriteLine($"The largest number is {numbers.Max()}");
    }
}