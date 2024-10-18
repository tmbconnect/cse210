using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Jhon Doe", "Math");
        Console.WriteLine(assignment.GetSummary());
    }
}