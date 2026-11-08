using System;

class Program
{
    static void Main(string[] args)
    {
        Resume MyResume = new Resume();
        MyResume._name = "John Doe";

        Job job1 = new Job();
        job1._jobTitle = "Web Developer Junior";
        job1._company = "Johnson&Johnson";
        job1._startYear = 2019;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._jobTitle = "Web Developer";
        job2._company = "Johnson&Johnson";
        job2._startYear = 2020;
        job2._endYear = 2022;

        Job job3 = new Job();
        job3._jobTitle = "Data Analyst";
        job3._company = "Apple";
        job3._startYear = 2022;
        job3._endYear = 2023;

        Job job4 = new Job();
        job4._jobTitle = "Software Engineer";
        job4._company = "Microsoft";
        job4._startYear = 2026;
        job4._endYear = 2023;

        MyResume._jobs.Add(job4);
        MyResume._jobs.Add(job3);
        MyResume._jobs.Add(job2);
        MyResume._jobs.Add(job1);

        MyResume.Display();
    }
}