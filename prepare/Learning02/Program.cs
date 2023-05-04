using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company="Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear=0;
        job1._endYear=3;

        Job job2 = new Job();
        job2._company="Apple";
        job2._jobTitle = "DevOps";
        job2._startYear=4;
        job2._endYear=6;


        Resume myResume = new Resume();
        myResume._name="Marco Silva";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
        
    }
}