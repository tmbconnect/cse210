using System;
public class Reference
{
    // Attributes private
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Reference constructor to handle scripture reference with one verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    // Reference constructor to handle scripture reference with two verses
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    // Display text method 
   public string GetDisplayText()
   {
        return "";
   }
}