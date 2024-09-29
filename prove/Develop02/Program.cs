using System;

class Program
{
    static void Main(string[] args)
    {
        // Menu to display the journal
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;

        // Menu with a while loop and switch cases to handle user choice
        while(running)
        {
           Console.WriteLine("Menu:"); 
           Console.WriteLine("1. Write a new entry");
           Console.WriteLine("2. Display the journal");
           Console.WriteLine("3. Save the journal to a file");
           Console.WriteLine("4. Load the journal from a file");
           Console.WriteLine("5. Exit");
           string choice = Console.ReadLine();
        }
        switch (choice)
        {
           case "1":
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                string entryText = Console.ReadLinde();
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                
        }
        
    }
}