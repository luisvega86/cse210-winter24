using System;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new ();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}