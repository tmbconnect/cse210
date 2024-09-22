using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        // variable to hold number of times it took user to guess
        int guessAttempts = 0;

        Console.WriteLine("Let's Play the magic number game!");
        Console.WriteLine("I will pick a number between 1- 100 and you guess what it is.");

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            guessAttempts += 1;

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine($"Congratulations! The magic number is {magicNumber}");
                Console.Write($"It took you {guessAttempts} to guess the magic number.");
            }
        }

    }
}