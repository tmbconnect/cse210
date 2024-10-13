using System;
public class Scripture{

    // Attributes (fields) for the Scripture class
    private Reference _reference; 
    private List<Word> _words = new List<Word>();
    
    // Scripture Constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        // split the text into words and add each word to the list.
        foreach (var word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }

        
    }

    // Method to hide random words 
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        // Ensure that we do not hide more words then are available
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();
         // No visable words to hide
        if (visibleWords.Count == 0) ; return;  

        numberToHide = Math.Min(numberToHide, visibleWords.Count);

        while (hiddenCount < numberToHide)
        {
            // Select a random word that is not already hidden
            int index = random.Next(visibleWords.Count);
            Word wordToHide = visibleWords[index];

            // Hide the word and remove it from the list of visable words
            wordToHide.Hide();
            visibleWords.RemoveAt(index);

            // Hidden word counter
            hiddenCount++;

        }
  
    }
    // Get display text method : returns a string
    public string GetDisplayText()
    {
        // Combine the words back into a single string
        string retrievedText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        Console.WriteLine(retrievedText);
        return retrievedText;
        
    }

    // Is Completely Hidden Method Bool value returns true or false
    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }





}