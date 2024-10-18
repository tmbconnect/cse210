using System;
using System.Security.Cryptography.X509Certificates;

// Create class
class BreathingActivity : Activity
{
   // Constructor to initialize attributes
   public BreathingActivity(string name, string description, int duration)
        :base(name, description, duration)
        {

        }

        //Run method
        public void Run() 
        {
        // Placeholder for breathing activity logic
        DisplayStartingMessage();
        ShowCountDown(_duration);
        DisplayEndingMessage();
        }
            
      
}