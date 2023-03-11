using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int option = 0;
        int score = 0;

        List<Goal> goals = new List<Goal>();

        while (option != 6)
        {
            Console.WriteLine("");
            Console.WriteLine($"You have {score} points.");

            Console.WriteLine("");
            Console.WriteLine("Menu Options:"); // Main Menu
            Console.WriteLine("    1. Create New Goal");
            Console.WriteLine("    2. View All Goals");
            Console.WriteLine("    3. Record Event");
            Console.WriteLine("    4. Save Goals");
            Console.WriteLine("    5. Load Goals");
            Console.WriteLine("    6. Quit");
            
            Console.WriteLine("");
            Console.Write("Select an option from the menu: ");
            option = int.Parse(Console.ReadLine());

            if (option == 1) // Menu - Create New Goal
            {
                Console.WriteLine("");
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("    1. Simple Goal");
                Console.WriteLine("    2. Eternal Goal");
                Console.WriteLine("    3. Checklist Goal");
                Console.Write("What type of goal would you like to create? ");
                string goal = Console.ReadLine();

                if (goal == "1") // Create Simple Goal
                {
                    string type = "SimpleGoal";
                    goals.Add(new SimpleGoal(type));
                }

                else if (goal == "2") // Create Eternal Goal
                {
                    string type = "EternalGoal";
                    goals.Add(new EternalGoal(type));
                }

                else if (goal == "3") // Create Checklist Goal
                {
                    string type = "ChecklistGoal";
                    goals.Add(new ChecklistGoal(type));
                }

                else // Invaild Option - Error Message
                {
                    Console.WriteLine("Invaild Option. Please try again.");
                }
            }

            else if (option == 2) // View All Goals
            {
                Goal display = new Goal();
                display.DisplayAll(goals); // Display All Goals In List
            }

            else if (option == 3) // Record Event
            {
                Goal display = new Goal();
                display.DisplayAll(goals); // Display All Goals In List

                Console.WriteLine("");
                Console.Write("Which goal did you accomplish? ");
                int accomplished = int.Parse(Console.ReadLine());

                int earned = goals[accomplished-1].RecordEvent(); // Record event and return points earned
                score = score + earned; // Add earned points to total score
            }

            else if (option == 4) // Save Goals to file
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();

                SaveLoad save = new SaveLoad(filename);
                save.SaveFile(goals);
            }

            else if (option == 5) // Load Goals from file
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();

                SaveLoad load = new SaveLoad(filename);
                (goals, score) = load.LoadFile(); // Assign values to goals list and score
            }

            else if (option != 6) // Error message
            {
                Console.WriteLine("");
                Console.WriteLine("Invalid Option. Please try again.");
            }
        }

        Console.WriteLine("");
        Console.WriteLine("Thank you! Goodbye!");
        Console.WriteLine("");
    }
}