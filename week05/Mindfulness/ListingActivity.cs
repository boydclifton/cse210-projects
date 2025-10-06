using System;
using System.Collections.Generic;
using System.Threading;
public class ListingActivity : Activity
{
    private List<string> _prompts;
    private Random _rand = new Random();

    

    public ListingActivity() :
        base("Listing Activity",
             "This activity helps you reflect on the good aspects of a certain area. ")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people you’ve helped this week?",
            "When have you felt peace this month?",
            "Who are some of your personal heroes?"
        };
    }
    
    private string GetRandomPrompt()
{
    
    Random randomGenerator = new Random();

    
    int randomIndex = randomGenerator.Next(_prompts.Count);

    
    return _prompts[randomIndex];
}

public void Run()
    {
        
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();

        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Console.WriteLine("You will begin shortly...");
        ShowCountDown(5);

        
        int timeLimit = GetDuration();

        
        int itemsListed = 0;

        
        List<string> userItems = new List<string>();

        
        DateTime startTime = DateTime.Now;

        Console.WriteLine();
        Console.WriteLine($"Start listing! You have {timeLimit} seconds.");
        Console.WriteLine("(Press Enter after each item.)");
        Console.WriteLine();

        
        while ((DateTime.Now - startTime).TotalSeconds < timeLimit)
        {
            Console.Write("> ");
            string userInput = Console.ReadLine();

            
            if (userInput != "")
            {
                userItems.Add(userInput);
                itemsListed++;
            }
        }

        
        Console.WriteLine();
        Console.WriteLine("Time's up!");
        Console.WriteLine($"You listed {itemsListed} items!");



        
        DisplayEndingMessage();
    }
}    