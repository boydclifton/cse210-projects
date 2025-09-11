using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Facebook";
        job1._jobTitle = "Information Technologist";
        job1._startYear = 2011;
        job1._endYear = 2017;

        Job job2 = new Job();
        job2._company = "Adobe";
        job2._jobTitle = "Design Manager";
        job2._startYear = 2018;
        job2._endYear = 2023;

        

        Resume myResume = new Resume();
        myResume._name = "Boyd Stinnet";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.DisplayResume();


    }

}