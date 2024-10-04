using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances using different constructors
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6, 7);
        

        // Display the fractions and their decimal values
        Console.WriteLine(fraction1.GetFractionString());  // Output 1/1
        Console.WriteLine(fraction1.GetDecimalValue());    // Output 1

        Console.WriteLine(fraction2.GetFractionString());  // Output 6/1
        Console.WriteLine(fraction2.GetDecimalValue());    // Output 6

        Console.WriteLine(fraction3.GetFractionString());  // Output 6/7
        Console.WriteLine(fraction3.GetDecimalValue());    // Output 0.8571428571428751

        // Test Getters and Setters
        fraction3.SetTop(3);
        fraction3.SetBottom(4);
        Console.WriteLine(fraction3.GetFractionString()); //Output 3/4
        Console.WriteLine(fraction3.GetDecimalValue());   // Output 0.75

    }
}