using System;

class Program
{
    static void Main(string[] args)
    {
        int option = 0;

        while (option != 5)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Activity Options:");
            Console.WriteLine("    1. Breathing Activity");
            Console.WriteLine("    2. Reflection Activity");
            Console.WriteLine("    3. Listing Activity");
            Console.WriteLine("    4. Grounding Activity");
            Console.WriteLine("    5. Quit");
            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());
            Console.Clear();

            if (option == 1) // Breathing Activity
            {
                BreathingActivity breathing = new BreathingActivity("Breathing Activity",
                "This activity will help you relax by walking your " + 
                "through breathing in and out slowly. Clear your mind " + 
                "and focus on your breathing.");
                breathing.DisplayBreathing();
            }

            else if (option == 2) // Reflection Activity
            {
                ReflectionActivity reflection = new ReflectionActivity("Reflection Activity",
                "This activity will help you reflect on times in your " + 
                "life when you have shown strength and resilience. " + 
                "This will help you recognize the power you have and " + 
                "how you can use it in other aspects of your life.");
                reflection.DisplayReflection();
            }

            else if (option == 3) // Listing Activity
            {
                ListingActivity listing = new ListingActivity("Listing Activity",
                "This activity will help you reflect on the good things " + 
                "in your life by having you list as many things as you " + 
                "can in a certain area.");
                listing.DisplayListing();
            }

            else if (option == 4) // Grounding Activity
            {
                GroundingActivity grounding = new GroundingActivity("Grounding Activity",
                "This activity will help you relax during an anxiety or panic attack.");
                grounding.DisplayGrounding();
            }

            else if (option != 5) // Error Message
            {
                Console.WriteLine("Invalid Option. Please try again.");
            }
        }

        Console.WriteLine("Thank you for using Mindfulness.");
        Console.WriteLine("Goodbye!");
        Console.WriteLine("");
    }
}