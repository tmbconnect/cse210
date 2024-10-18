using System;

class MathAssignment : Assignment
{
    // attributes for MathAssignment class
    private string _textbookSection;
    private string _problems;
    
    // Constructor for MathAssignment class with base class
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) 
    :base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;

    }
     // GetHomeworkList method returns _textbookSection, and _problems
    public string GetHomeworkList()
    {
        return $"{_textbookSection} Problems {_problems}";

    }
}