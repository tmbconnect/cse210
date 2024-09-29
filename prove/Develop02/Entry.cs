using System;
// Public class that matches my .cs file
public class Entry
{
    // Attributes
    public string _date;
    public string _promptText;
    public string _entryText;

    // Constroctor to initialize the Entry object
    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    // Method to display the entry details
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine();
    }




}