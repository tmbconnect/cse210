using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        //variable to hold user input
        int userInput = -1;
        // loop to enter numbers to the list

        while(userInput != 0)
        {
            Console.Write("Enter a number (Not Zero) (0 to quit): ");

            string userResponse = Console.ReadLine();
            userInput = int.Parse(userResponse);

            // add number to the list if the number is not 0
            if(userInput != 0)
            {
                numbers.Add(userInput);
            }

        }

        // Part 1: Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum : {sum}");

        // Part 2: Compute the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Part 3: Find the max
        int max = numbers[0];
        
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max number is: {max}");
    }

}