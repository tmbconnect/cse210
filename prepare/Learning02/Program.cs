using System;

class Program
{
    static void Main(string[] args)
    {
        //Create new job instance named job1.
        Job job1 = new Job();
        // Set member variables using the dot notation.
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        
        // create new instance of the Resume class
        Resume myResume = new Resume();
        myResume._personName = "Allison Rose";
        // add job1 and job2 to the Jobs list
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}