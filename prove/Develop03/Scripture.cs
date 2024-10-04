using System;
public class Scripture{

    // Attributes (fields) for the Scripture class
    private Reference _reference; 
    private List<Word> _words = new List<Word>();

    // Scripture Constructor
    Scripture(Reference reference, string text)
    {
        _reference = reference;
        
    }

    // Hide random words method
    public void HideRandomWords(int numberToHide)
    {

    }
    // Get display text method : returns a string
    public string GetDisplayText()
    {
        return "";
    }

    // Is Completely Hidden Method Bool value returns true or false
    public bool IsCompletelyHidden()
    {
        return false;
    }





}