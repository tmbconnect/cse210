using System;
public class Word{

    // Private attributes
    private string _text;
    private bool _isHidden;

    // Word Constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Hide method 
    public void Hide()
    {
        _isHidden = true;
    }

    // Show method
    public void Show()
    {
        _isHidden = false;
    }

    // Is Hidden method returns a bool 
    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _text;
    }
}