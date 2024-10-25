using System;

class Program
{
    static void Main(string[] args)
    {   // Create Square instance, call GetColor() and GetArea() methods
        Square mySquare = new Square("Pink", 5);
        Console.WriteLine(mySquare.GetColor());
        Console.WriteLine(mySquare.GetArea());
        Console.WriteLine();

        // Create Rectangle instance, call GetColor() and GetArea() methods
        Rectangle myRectangle = new Rectangle("Purple", 10, 3);
        Console.WriteLine(myRectangle.GetColor());
        Console.WriteLine(myRectangle.GetArea());
        Console.WriteLine();

        // Create Circle instance, call GetColor() and GetArea() methods
        Circle myCircle = new Circle("Green", 3);
        Console.WriteLine(myCircle.GetColor());
        Console.WriteLine(myCircle.GetArea());
        Console.WriteLine();

    }
}