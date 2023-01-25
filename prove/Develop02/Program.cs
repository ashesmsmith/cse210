using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Open the journal and leave it open for the whole session
        Journal theJournal = new Journal();

        // Add prompts to list
        Prompt choosePrompt = new Prompt();
        choosePrompt._prompts.Add(choosePrompt._prompt1);
        choosePrompt._prompts.Add(choosePrompt._prompt2);
        choosePrompt._prompts.Add(choosePrompt._prompt3);
        choosePrompt._prompts.Add(choosePrompt._prompt4);
        choosePrompt._prompts.Add(choosePrompt._prompt5);

        // Begin user experenice/Load or New Journal
        Console.WriteLine("");
        Console.WriteLine("Welcome to the Journal Program!");
        Console.Write("Would you like to load an exsisting ");
        Console.Write("journal (L) or begin a new (N) one? ");
        string loadStart = Console.ReadLine();

        if (loadStart == "L") // Load an exsisting journal
        {
            Console.Write("Please enter the filename for the journal to LOAD: ");
            theJournal._journalFile = Console.ReadLine();
            theJournal.LoadFile();
        }

        else if (loadStart == "N") // Write a new journal
        {
            Console.Write("Please enter a filename for the NEW journal: ");
            theJournal._journalFile = Console.ReadLine();
            theJournal.SaveFile();
        }

        // Begin journal options
        int menuOption = -1;

        while (menuOption != 5)
        {
            Console.WriteLine("");
            Console.WriteLine("Please choose from the following options:");
            Console.WriteLine("1. New Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Exit Program");
            Console.Write("> ");
            menuOption = int.Parse(Console.ReadLine());

            // Generate prompt, allow user to write response
            if (menuOption == 1)
            {
                Console.WriteLine("");

                Entry newEntry = new Entry();
                // Prompt
                newEntry._prompt = choosePrompt.DisplayPrompt();
                Console.WriteLine(newEntry._prompt);
                Console.Write("> ");
                // Response
                newEntry._response = Console.ReadLine();
                // Date
                DateTime currentTime = DateTime.Now;
                newEntry._date = currentTime.ToShortDateString();

                // Add entry to the list
                theJournal._entries.Add(newEntry);
            }

            // All journal entries are displayed
            else if (menuOption == 2)
            {
                theJournal.DisplayJournal();
            }

            // Prompt user for a filename to save journal
            else if (menuOption == 3)
            {
               theJournal.SaveFile();
               Console.WriteLine("");
               Console.WriteLine("The journal has been saved.");
            }

            // Save current file and prompt user for a filename 
            // to load a different journal
            else if (menuOption == 4)
            {
               Console.Write("Would you like to save changes and load a new journal? (Y/N) ");
               string saveContinue = Console.ReadLine();

               if (saveContinue == "Y")
               {
                // Save current file
                theJournal.SaveFile();
                Console.WriteLine("The journal has been saved.");
                Console.WriteLine("");

                // Clear all previous entries before loading new
                theJournal._entries.Clear();

                // Load new file
                Console.Write("Please enter the filename of the journal to LOAD: ");
                theJournal._journalFile = Console.ReadLine();
                theJournal.LoadFile();
               }

               else {}
            }

            // End Program
            else if (menuOption == 5)
            {
                string saveExit = "";
                Console.Write("Would you like to save your journal first? Y/N ");
                saveExit = Console.ReadLine();

                if (saveExit == "Y")
                {
                    theJournal.SaveFile();
                    Console.WriteLine("");
                    Console.WriteLine("Thank you for using Journal Program!");
                    Console.WriteLine("");
                }

                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Thank you for using Journal Program!");
                    Console.WriteLine("");
                }
            }

            // Invalid Option Error Message
            else
            {
                Console.WriteLine("Invalid Option. Please try again.");
            }
        }
    }
}