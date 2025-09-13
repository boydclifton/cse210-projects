using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();

        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;

        while (running) 
        {
            Console.WriteLine();
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: [1-5] ");
            string menuNumber = Console.ReadLine();


            if (menuNumber == "1")
            {
                string prompt = promptGenerator.GetPrompt();
                Console.WriteLine(prompt + "\n");
                string response = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._dateText = DateTime.Now.ToShortDateString();
                newEntry._promptText = prompt;
                newEntry._entryText = response;
                myJournal.AddEntry(newEntry);
            }

            else if (menuNumber == "2")
            {
                myJournal.DisplayEntries();
            }

            else if (menuNumber == "3")
            {
                Console.WriteLine("Please enter what the file will be saved as: ");
                string filename = Console.ReadLine();
                myJournal.SaveEntry(filename);
            }

            else if (menuNumber == "4")
            {
                Console.WriteLine("Enter filename exactly: ");
                string filename = Console.ReadLine();
                myJournal.LoadEntry(filename);
            }

            else if (menuNumber == "5")
            {
                Console.WriteLine("Thanks for stopping by!");
                running = false;
            }

            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
        
    }

    
}