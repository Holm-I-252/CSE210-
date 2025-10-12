using System.Diagnostics.Contracts;

public class Activity
{
    private string _closingMessage = "Thank you for participating in the activity!";
    protected int _duration;

    public void InputDuration()
    {
        Console.Write("Enter the duration of the activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void WaitWithCountdown()
    {
        Console.WriteLine("Get ready...");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void WaitActivityDuration()
    {
        for (int i = _duration; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void DisplayClosingMessage()
    {
        Console.WriteLine(_closingMessage);
        Thread.Sleep(3000);
        Console.Clear();
    }

    public void DisplayStartingMessage(string activityName, string description)
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {activityName}.");
        Console.WriteLine();
        Console.WriteLine(description);
        Console.WriteLine();
    }
    public void SpinnerAnimation(int duration)
    {
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            foreach (char c in "|/-\\")
            {
                Console.Write(c);
                Thread.Sleep(200);
                Console.Write("\b");
            }
        }
    }
    public void chooseRandomPrompt(List<string> prompts)
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        Console.WriteLine(prompts[index]);
    }
}