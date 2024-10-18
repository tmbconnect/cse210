using System;

class MathAssignment : Assignment
{
    // attributes for MathAssignment class
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems) 
    :base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;

    }

    public string GetHomeworkList()
    {
        return $"{_textbookSection} Problems {_problems}";

    }
}