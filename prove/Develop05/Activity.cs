using System;

// Create Activity class
class Activity
{
    // Base class attributes shared by BreathingActivity Class, ListingActivity Class, ReflectingActivity Class
    protected string _name;
    protected string _description;
    protected int _duration;
    
    // Constructor initialize attributes
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    
    // Method to display the starting message
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name}");
        Console.WriteLine($"{_description}");
        Console.Write("Enter the duration of the activity in seconds: ");

        // Get the duration from the usser and update the _duration variable
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Prepare to begin...");
        //Pause for a few seconds before starting.
        ShowSpinner(3);


    }
    
    // Ending Message
    public void DisplayEndingMessage()
    {
        

    }

    // Show Spinner
    public void ShowSpinner(int seconds)
    {

    }

    // Show Count Down
    public void ShowCountDown(int seconds)
    {

    }

}