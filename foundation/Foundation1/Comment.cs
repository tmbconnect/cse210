using System;

public class Comment 
{
    // Attributes for Comment class
    private string _commenterName;
    private string _commentText;

    // Comment Constructor
    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }

    // Method to get the display text fo the comment
    public string GetDisplayText()
    {
        return $"{_commenterName} : {_commentText}";
    }
}