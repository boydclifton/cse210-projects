using System;
using System.Threading;
using System.Collections.Generic;

public class BreathingActivity : Activity
{
    public BreathingActivity() :
        base("Breathing Activity",
             "This activity helps you relax with mindful breathing. Calmly focus on each breathe.")
    { }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        DateTime end = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < end)
        {
            AnimateBreath("Breathe in...", true);  
            AnimateBreath("Breathe out...", false); 
        }

        DisplayEndingMessage();
    }
    private void AnimateBreath(string message, bool growing)
    {
        Console.Clear();
        Console.WriteLine();

        int steps = 8;  
        int delay = 300; 

        if (growing)
        {
            for (int i = 1; i <= steps; i++)
            {
                Console.WriteLine(new string(' ', i * 2) + message);
                Thread.Sleep(delay);
                Console.Clear();
            }
        }
        else 
        {
            for (int i = steps; i >= 1; i--)
            {
                Console.WriteLine(new string(' ', i * 2) + message);
                Thread.Sleep(delay);
                Console.Clear();
            }
        }
    }
}
