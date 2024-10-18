using System;

class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) 
    :base(studentName, topic)
    {
        _title = title;
    }

    // Method to rueturn title from WritingAssignment class
    public string GetWritingInformation()
    {
        return  _title;
    }
}