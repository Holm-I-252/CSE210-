public class Reflection : Activity
{
    private string _activityName = "Reflection Activity";
    private string _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    private string _instructions = "Consider the prompt above. The activity will begin shortly.";
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public void StartReflectionActivity()
    {
        base.DisplayStartingMessage(_activityName, _description);
        base.InputDuration();
        base.chooseRandomPrompt(_prompts);
        Console.WriteLine(_instructions);
        base.SpinnerAnimation(5);
        Console.Clear();
        DateTime endTime = DateTime.Now.AddSeconds(base._duration);
        while (DateTime.Now < endTime)
        {
            base.chooseRandomPrompt(_questions);
            base.SpinnerAnimation(5);
            Console.Clear();
        }
        base.DisplayClosingMessage();
    }
}