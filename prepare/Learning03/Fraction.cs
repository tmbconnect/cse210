public class Fraction
{
    private int _top;
    private int _bottom;

// Constuctor that inializes the fraction 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
// Constructor that intializes the fraction to top 1
    public Fraction(int top)
    {
        _top = 1;
        _bottom = 1;
    }
// Constructor that initalizes the fraction to top/bottom
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
// Getter for the top value
   public int GetTop()
    {
        return _top;
    }
// Setter for the top value 
    public void SetTop(int top)
    {
        _top = top;
    }
// Getter for the bottom value
 public int GetBottom()
    {
        return  _bottom;
    }
// Setter for the bottom value 
  public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
// Method to return the fraction as a string
   public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
// Method to retrun the decimal value of the fraction
  public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }

}