using System;
using System.Security.Cryptography;
using System.Transactions;
public class Video
{
    // Atributes for the video class
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments = new List<Comment>();

    // Video constructor
    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;

    }

    //Method to add a comment to the video
    public void AddComment(Comment, comment)
    {
        _comments.Add(comment);
    }

    //Method to return the number of comments
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    //Method to get the details of the video (title, author, length)
    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Lenthth: {_lengthInSeconds}");
        Console.WriteLine($"Number of comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");

        foreach (var comment in _comments)
        {
            Console.WriteLine($"\t- {comment.GetDisplayText()}");
        }

        Console.WriteLine();
    }

}
