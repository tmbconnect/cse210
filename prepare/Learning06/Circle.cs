using System;
class Circle : Shape
{
    // Attributes for Circle class
    private double _radius;

    // Constructor for Circle class
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // Implement inherited abstract GetArea method from base Shape 
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}