using System;

class Program
{
    static void Main(string[] args)
    {
        // Loop the menu to let the user choose an activity. 
        bool keepRunning = true;

        while (keepRunning)
        {
            // Clear the console for a fresh menu display
            Console.Clear();
            Console.WriteLine("Nindfullness App");
            Console.WriteLine("Please choose an activity");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Enter your choice (1-4): ");

            string choice = Console.ReadLine();

            // switch case statements for the menu choices
            switch (choice)
            {
                case "1":
                    // Breathing Activity
                    Console.Clear();
                    BreathingActivity breathingActivity = new BreathingActivity
                    (
                        "Breathing Activity",
                        "This activity will help you relax by guiding you through slow, mindful breathing. Clear your mind and focus on your breathing.",
                        // Initial duration will be set later
                        0
                    );

                    // Run the breathing activity
                    breathingActivity.Run();
                    break;

                case "2":
                    // Reflecting Activity
                    Console.Clear();
                    ReflectingActivity reflectingActivity = new ReflectingActivity(

                        "Reflecting Activity",
                        "This activity will help you reflect on times in your life when you've shown strength and resilience.",
                        // Initial duration will be set later
                        0
                    );

                    // Run the reflecting activity 
                    reflectingActivity.Run();
                    break;

                case "3":
                    // Listing Activity
                    Console.Clear();
                    ListActivity listActivity = new ListActivity(
                    "Listing Activity",
                    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
                    // Initial duration will be set later
                    0,
                    // Initial count for listed items
                    0,
                    // Prompts will be initialized later
                    null
                    );

                    // Run the listing activity
                    listActivity.Run();
                    break;

                case "4":
                    // Quit the program
                    Console.WriteLine("Thank you for using the Mindfulness App. Goodbye!");
                    keepRunning = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    break;

            }

            if (keepRunning)
            {
                Console.WriteLine("\nPress Enter to return to the menu...");

                // Pause for user to see result before returning to the menu
                Console.ReadLine();
            }

       }

    }
}
       