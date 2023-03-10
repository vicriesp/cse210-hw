using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Walmart";
        job1._jobTitle = "Warehouse";
        job1._startYear = 2003;
        job1._endYear = 2009;

        Job job2 = new Job();
        job2._jobTitle = "Cashier";
        job2._company = "Smith's";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Victor Rivera";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}