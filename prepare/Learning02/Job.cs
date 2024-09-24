using System;
 public class Job
 {
    // Attributes
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {startYear} - {endYear}")
    }
  }