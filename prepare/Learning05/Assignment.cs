using System;

class Assignment
{    
    // base class student name and topic attributes
    protected string _studentName;
    protected string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName}, {_topic}";
    }

}