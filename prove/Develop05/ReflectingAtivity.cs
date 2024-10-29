using System;

// Create class
class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What was your favorite thing about this experience?",
        "What did you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keeping this experience in mind help you in the future?"
    };

    // Constructor to intialize attributes
    public ReflectingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
           
    }

    // Method to get random prompt
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];

    }
    
    // Method to get a random question
    public string GetRandomQuestion()
    {
        Random rand = new Random();
        int index = rand.Next(_questions.Count);
        return _questions[index];
    }

    // Method to display prompt
    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);

        // Pause to let the user think about the 
        ShowCountDown(5); 

    }

    // Method to display questions with a pause
    public void DisplayQuestions()
    {
        string question = GetRandomQuestion();
        Console.WriteLine(question);
        ShowSpinner(5);

    }

      // Run method to perform the reflecting activity
    public void Run()
    {   // Call Starting Message method from base activity class
        DisplayStartingMessage();

        // Display a random prompt.
        DisplayPrompt();

        // Display all unique questions before repeating and add a 3 second pause after each question
        HashSet<string> shownQuestions = new HashSet<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();
            if(!shownQuestions.Contains(question))
            {
                Console.WriteLine(question);
                shownQuestions.Add(question);
                ShowSpinner(5);
            }

            // If all questions have been shown, reset questions list
            if(shownQuestions.Count == _questions.Count)
            {
                shownQuestions.Clear();
            }
           
        }

        // Call the transition message from the base activity class before the ending message
        DisplayTransition("Finishing the reflection activity...", 3);
        // Call Ending Message from Base Activity class. 
       DisplayEndingMessage();
    }
}