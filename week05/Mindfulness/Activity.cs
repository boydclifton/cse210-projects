using System;
using System.Threading;
using System.Collections.Generic;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public int GetDuration()
    {
        return _duration;
    } 

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine() ?? "30");

        Console.WriteLine();
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Good job!");
        ShowSpinner(2);
        Console.WriteLine();
        Console.WriteLine($"You completed the {_name} for {_duration} seconds.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
{
   
    List<string> spinnerFrames = new List<string> { "|", "/", "—", "\\" };

    DateTime endTime = DateTime.Now.AddSeconds(seconds);

    Console.CursorVisible = false; 

    while (DateTime.Now < endTime)
    {
        
        foreach (string frame in spinnerFrames)
        {
            Console.Write(frame);      
            Thread.Sleep(150);         
            Console.Write("\b \b");    

            
            if (DateTime.Now >= endTime)
                break;
        }
    }

    Console.CursorVisible = true; 
}
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}

