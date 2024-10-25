using System;
abstract class Shape
{
    // Attributes for Shape class
    protected string _color;

    //Shape constructor
    protected Shape(string color)
    {
        _color = color;
    }

    //Method to set the shape color
    public void SetColor(string color)
    {
        _color = color;
    }
        
    //Method to get color
    public string GetColor()
    {
        return _color;
    }

    //Abstract method to be implemented by each derived shape class
    public abstract double GetArea();
}
