using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._companyName = "Microsoft";
        job1._entryYear = 2019;
        job1._outYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._companyName = "Apple";
        job2._entryYear = 2022;
        job2._outYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}