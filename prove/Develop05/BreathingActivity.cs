using System;

// Create class
class BreathingActivity : Activity
{
   // Constructor to initialize attributes
   public BreathingActivity(string name, string description, int duration)
        :base(name, description, duration)
        {

        }

     //Run  method to perform the breathing activity.
    public void Run() 
{
        // Call Starting Message method from base activity class
        DisplayStartingMessage();

        // Each breathe in and breathe out cycle lasts 5 seconds
        int breatheInDuration = 5;
        int breathOutDuration = 5;

                // Calcualte how many fully cycles can fit in the specified time duration
                int totalCycles = _duration / (breatheInDuration + breathOutDuration);


        for (int i = 0; i < totalCycles; i++)
        {
                // Breath in and show countdown for breathe in duration
                Console.WriteLine("Breathe in...");
                ShowCountDown(breatheInDuration);

                // Breathe out and show countdown for breath out duration
                Console.WriteLine("Breathe out...");
                ShowCountDown(breathOutDuration);
        }

                // Handle any remaining seconds (if time duration is not a multiple of 10)
                int remainingTime = _duration % (breatheInDuration + breathOutDuration);
                if(remainingTime > 0)
                {
                        Console.WriteLine("Breathe in...");
                        ShowCountDown(remainingTime / 2);

                        Console.WriteLine("Breathe out...");
                        ShowCountDown(remainingTime / 2);
                }

     // Call the transition method from base Activity class before ending
     DisplayTransition("Finishing the breathing activity...", 3);

     // Call Ending Message from Base Activity Class
     DisplayEndingMessage();
 }
            
      
}