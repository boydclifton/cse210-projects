using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Online Ordering System!");
        Console.WriteLine("Please select an option:");
        Console.WriteLine("1. Place an Order");
        Console.WriteLine("2. View Order Status");
        Console.WriteLine("3. Exit");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine("Placing an order...");
                // Add order placement logic here
                break;
            case "2":
                Console.WriteLine("Viewing order status...");
                // Add order status logic here
                break;
            case "3":
                Console.WriteLine("Exiting the system. Goodbye!");
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }      


    }



  
}