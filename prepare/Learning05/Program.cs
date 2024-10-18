using System;

class Program
{
    static void Main(string[] args)
    {
        // Test Assignment class
        Assignment assignment = new Assignment("Jhon Doe", "Math");
        Console.WriteLine(assignment.GetSummary());
        
        // Test MathAssignment class and inheritance from base class
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "8-9");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        // Test Writing Assignment class and inheritance from base class.
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}