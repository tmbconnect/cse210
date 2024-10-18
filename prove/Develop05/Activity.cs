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
    
    // Starting message
    public void DisplayStartingMessage()
    {

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