using System;

public class PromptGenerator
{
    // Attributes needed a list to hold the random prompts.
    public List<string> _prompts = new List<string>
    {
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "Who was the most interesting person I interacted with today?",
        "What am I most grateful for today?"
    };
     // Generate a random prompt.
    private Random _random = new Random();
    
    // Method to get the random prompt
    public string GetRandomPrompt()
    {

        int index = _random.Next(_prompts.Count);
        return _prompts[index];

    }
}