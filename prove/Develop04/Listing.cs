public class Listing : Activity
{
    private string _activityName = "Listing Activity";
    private string _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    private string _instructions = "You will be given a prompt and you will have to list as many responses as you can to the prompt within the time limit. The activity will begin shortly.";
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public void StartListingActivity()
    {
        base.DisplayStartingMessage(_activityName, _description);
        base.InputDuration();
        Console.WriteLine(_instructions);
        base.chooseRandomPrompt(_prompts);
        base.SpinnerAnimation(10);
        Console.Clear();
        Console.WriteLine("Start listing items:");
        DateTime endTime = DateTime.Now.AddSeconds(base._duration);
        int itemCount = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                itemCount++;
            }
        }
        Console.WriteLine($"You listed {itemCount} items!");
        base.DisplayClosingMessage();
    }
}