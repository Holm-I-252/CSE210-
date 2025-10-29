using System;

class Program
{
    static void Main(string[] args)
    {
        Running run1 = new Running(30, new DateTime(2023, 3, 1), 5.0);
        Cycling cycle1 = new Cycling(45, new DateTime(2023, 3, 2), 20.0);
        Swimming swim1 = new Swimming(60, new DateTime(2023, 3, 3), 40);

        List<Activity> activities = new List<Activity> { run1, cycle1, swim1 };
        foreach (var activity in activities)
        {
            activity.GetSummary();
        }
    }
}