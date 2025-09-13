using System;
using System.Collections.Generic;

public class Entry
{

    

    public string _dateText;
    public string _promptText;

    public string _entryText;
    
    


    public void DisplayEntry()
    {
        Console.WriteLine($"Date:  {_dateText}");
        Console.WriteLine($"Prompt:   {_promptText}");
        Console.WriteLine($"Response:   {_entryText}");
    }
}