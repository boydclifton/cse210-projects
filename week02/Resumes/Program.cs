using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Program Designer";
        job1._startYear = 2018;
        job1._endYear = 2020;
        job2._company = "Apple";
        job2._jobTitle = "Janitor";
        job2._startYear = 2020;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Boyd Stinnett";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();




    }

}

