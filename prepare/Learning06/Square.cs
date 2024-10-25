using System;
class Square : Shape
{
    // Attributes for Square class
    private double _side;

    //Constructor for Square class and includes inheritance from Shape class
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // Implement inherited abstract GetArea method from base Shape class
    public override double GetArea()
    {
        return _side * _side;
    }
}
