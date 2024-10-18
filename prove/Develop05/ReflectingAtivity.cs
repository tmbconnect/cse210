using System;

// Create class
class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    // Constructor to intialize attributes
    public ReflectingActivity(string name, string description, int duration)
        : base(name, description, duration)
        {
           
        }

    // Run method
    public void Run()
    {
        DisplayStartingMessage();
        // Placeholder for logic
        DisplayEndingMessage();

    }   

    // Method to get random prompt
    public string GetRandomPrompt()
    {
        // Place holder for logic
        return "";

    }
    
    // Method to get a random question
    public string GetRandomQuestion()
    {
        // Place holder for logic
        return "";

    }

    // Method to display prompt
    public void DisplayPrompt()
    {
        // Place holder for display info
    }

    // Method to display questions
    public void DisplayQuestions()
    {
        // Place holder for display info
    }

}