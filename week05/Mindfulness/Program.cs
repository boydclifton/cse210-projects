using System;
using System.Threading;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Menu Options");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("Select a choice from the menu: ");

            string number = Console.ReadLine();

            if (number == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }
            else if (number == "2")
            {
                ReflectingActivity reflect1 = new ReflectingActivity();
                reflect1.Run();
            }
            else if (number == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
            else if (number == "4")
            {
                running = false;
                Console.WriteLine();
                Console.WriteLine("Thanks for Stopping By!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid choice. Please type 1, 2, 3, or 4.");
                Console.WriteLine("Press any key to try again...");
                Console.ReadKey();
            }
        }
    }
}