using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    Entry entry = new Entry();



    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("There are no entries");
        }
        else
        {
            foreach (Entry newEntry in _entries)
            {
                newEntry.DisplayEntry();
            }
        }
    }

    public void SaveEntry(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._dateText}~{entry._promptText}~{entry._entryText}");
            }
        }
    }

    public void LoadEntry(string filename)
    {
        if (File.Exists(filename))
        {


            string[] lines = System.IO.File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split("~");
                Entry entry = new Entry();
                entry._dateText = parts[0];
                entry._promptText = parts[1];
                entry._entryText = parts[2];
                _entries.Add(entry);
            }
            Console.WriteLine($"Journal successfully loaded from filename - {filename} ");
        }
        else
        {
            Console.WriteLine($"filename does not exist. Please enter a valid filename");
        }
    }


    
}
