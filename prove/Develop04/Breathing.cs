public class Breathing : Activity
{
    private string _activityName = "Breathing Activity";
    private string _description = "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breathing.";
    private string _instructions = "Breathe in and out slowly as the program instructs you. The activity will begin shortly.";
    private bool _isRunning = false;

    public void StartBreathingActivity()
    {
        base.DisplayStartingMessage(_activityName, _description);
        base.InputDuration();
        Console.WriteLine(_instructions);
        base.SpinnerAnimation(5);
        Console.Clear();
        _isRunning = true;
        while (_isRunning)
        {
            Console.Write("Breathe in... ");
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i + " ");
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.Write("Now breathe out... ");
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i + " ");
                Thread.Sleep(1000);
            }
            Console.Clear();
            base._duration -= 10;
            if (base._duration <= 0)
            {
                _isRunning = false;
            }
        }
        base.DisplayClosingMessage();
    }
}