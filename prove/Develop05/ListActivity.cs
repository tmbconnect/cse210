using System;
using System.Reflection.Metadata.Ecma335;

// Create class
class ListActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    //Constructor to intialize attributes
    public ListActivity(string name, string description, int duration, int count, List<string> prompts)
        : base( name, description, duration)
        {
        _count = count;
        _prompts = prompts;

        }
        
        // Run Method
        public void Run()
        {
        DisplayStartingMessage();
        // Placeholder for additional logic
        DisplayEndingMessage();
        }

    // Method to get a random prompt
    public string GetRandomPrompt()
    {
        // Place holder for logic
        return "";

    }  

    // Method to get a list from user
    public List<string> GetListFromUser()
    {
        // place holder for logic
        return new List<string>();
    }
    


}