using System;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public Resume()
    {
    }

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Job:");
        foreach (Job i in _jobs)
        {
            i.Display();
        }
    }
}