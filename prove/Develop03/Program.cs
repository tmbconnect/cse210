using System;

class Program
{
    static void Main(string[] args)
    {
        // create a reference for a scripture (example: Proverbs 3, 5, 6)
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        //create a Scripture object with the scripture reference and text
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");

        // Loop to continue prompting user until all words are hidden.
        while (!scripture.IsCompletelyHidden())
        {
            // Clear the console screen
            Console.Clear();

            // Display the reference and the scripture text
            Console.WriteLine("Scripture: ");
            Console.WriteLine(reference.GetDisplayText());
            Console.WriteLine();
            scripture.GetDisplayText();

            // Prompt the user to Enter or type ("quit" to exit program)
            Console.WriteLine("\n Enter to hide more words, or type 'quit' to exit.");
            string userInput = Console.ReadLine();

            // Exit program if user types "quit"
            if (userInput.ToLower() == "quit")
            {
                break;
            }

            // If the user presses Enter without typing anything. Hide a few random words
            if (string.IsNullOrEmpty(userInput))
            {
                scripture.HideRandomWords(3);
            }
         }
           
           // Final message when all words are hidden or the user quits
         if (scripture.IsCompletelyHidden())
         {
            Console.Clear();
            Console.WriteLine("All words have been hidden. Thank you for your efforts today. Good Bye.");
         }
         else
         {
            Console.WriteLine("Nice job! Come back again soon.");
         }

    }
}