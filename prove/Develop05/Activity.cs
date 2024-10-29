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

    // Method to handle the transition before the ending message
    public void DisplayTransition(string message, int spinnerDuration)
    {
        Console.WriteLine(message);
        ShowSpinner(spinnerDuration);
    }

     // Ending Message method to display the ending message.
    public void DisplayEndingMessage()
    {

        // Show final message 
        Console.WriteLine($"Great Job! You have completed {_name} for {_duration} seconds.");

        // Ending spinner 
        ShowSpinner(3);


    }

    // Show Spinner method that creates the spinner and a loop for the spinner length that is equal to the user input. 
    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            i = (i + 1) % spinner.Length;
            Thread.Sleep(250);
            Console.Write("\b");
        }
        // Move to the next line after the spinner completes
        Console.WriteLine();

    }

    // Show Count Down method that will pause the program for 1 second
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }

    }

