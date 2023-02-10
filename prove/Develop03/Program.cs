using System;

class Program
{
    static void Main(string[] args)
    {
        // SETUP
        Scripture scripture = new Scripture("Trust in the Lord with all thine heart; " +
        "and lean not unto thine own understanding. " + "In all thy ways " +
        "acknowledge him, and he shall direct thy paths.");
        scripture.SetReference();

        // Startup - Display reference with full text
        Console.WriteLine("");
        Console.WriteLine("Welcome to the Scripture Memorizer Program!");
        Console.WriteLine("");
        scripture.Display();

        // BEGIN USER INTERACTION
        string userSelect = "";
        int max = scripture.Max();
        int total = -1; // max count starts at 0

        while (userSelect != "QUIT")
        {
            Console.Write("Please press ENTER to continue or type QUIT to end. ");
            userSelect = Console.ReadLine();
            total = total + 3; // +3 because 3 words hidden at a time

            if (userSelect == "" && total < max)
            {
                Console.Clear(); // Clear the screen
                scripture.HideWord(); // Hide Word 1
                scripture.HideWord(); // Hide Word 2
                scripture.HideWord(); // Hide Word 3
                scripture.Display(); // Display modifed text
            }

            else if (userSelect == "" && total >= max)
            {
                userSelect = "QUIT";
            }

            else if (userSelect != "QUIT")
            {
                Console.WriteLine("");
                Console.WriteLine("Invalid Option. Please try again.");
            }
        }

        // END PROGRAM
        Console.WriteLine("");
        Console.WriteLine("Goodbye!");
        Console.WriteLine("");
    }
}