using System;
using System.Threading;
using System.Collections.Generic;



public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random _rand = new Random();

    public ReflectingActivity() :
        base("Reflection Activity",
             "This activity helps you reflect on times you showed resilience. You are stronger than you know.")
    {
        _prompts = new List<string>
{
    "Think of a time when you tried something new and learned from it.",
    "Think of a moment when you helped someone without expecting anything in return.",
    "Think of a time when you felt truly proud of yourself.",
    "Think of a situation where you stayed calm under pressure.",
    "Think of a time when you made a positive difference for someone.",
    "Think of a time when you chose kindness even when it was hard."
};
        _questions = new List<string>
        {
            "What emotions did you feel during that experience?",
            "What made that moment meaningful to you?",
            "What challenges did you overcome to get there?",
            "What lessons can you carry into the future from this moment?",
            "If you could relive that experience, what would you do the same?",
            "How has this moment shaped who you are today?",

        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();

        Console.WriteLine($"{GetRandomPrompt()}");
        Console.WriteLine("Think about this...");
        ShowSpinner(5);

        int duration = GetDuration();
        DateTime end = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < end)
        {
            Console.WriteLine();
            Console.WriteLine($"{GetRandomQuestion()}");
            ShowSpinner(10);
        }

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
      return  _prompts[_rand.Next(_prompts.Count)];
    } 
    private string GetRandomQuestion()
    {
        return _questions[_rand.Next(_questions.Count)];
    }
}