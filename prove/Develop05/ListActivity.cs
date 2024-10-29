using System;

// Create class
class ListActivity : Activity
{
    // Attributes for ListActivity Class
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    //Constructor to intialize attributes
    public ListActivity(string name, string description, int duration, int count, List<string> prompts)
        : base(name, description, duration)
    {
        _prompts = prompts ?? new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    }

             
        // Run Method to perforn the listing activity
        public void Run()
        {
        // Call Starting Message form base Activity class
        DisplayStartingMessage();

        // Select and display a random prompt
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);

        // Give the user a coundown to think about the prompt.
        ShowCountDown(5);

        // Get the list from the user
        List<string> userList = GetListFromUser();

        // Display the number of list items from user
        Console.WriteLine($"You entered {userList.Count} items: ");

        // Display the list of items
        foreach (var item in userList)
        {
            Console.WriteLine($"- {item}");
        }

        // Call the transistion method before ending the activity
        DisplayTransition("Finishing the listing activity...", 3);

        // Call the Ending Message from base class
        DisplayEndingMessage();

        }
        

    // Method to get a random prompt
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }  

    // Method to get a list from user
    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        // Allow user to enter list items
        Console.WriteLine("Start listing items (press Enter to submit each item).");

        // While loop  to allow user to submit items until the time duration is over.
        while (DateTime.Now < endTime) 
        {
            string userInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(userInput))
            {
                items.Add(userInput);
            }
        }
        // Let user know the time to add to the list is up
        Console.WriteLine("Time's up!");
        return items;
    }
    


}