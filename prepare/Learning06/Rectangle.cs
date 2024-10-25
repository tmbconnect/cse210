using System;
class Rectangle : Shape
{
    //Attributes for Rectangle class
    private double _length;
    private double _width;

    // Rectangle class constructor that includes inheritance from base Shape class
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    // Implement inherited abstract GetArea method from base Shape class
    public override double GetArea()
    {
        return _length * _width;
    }
}