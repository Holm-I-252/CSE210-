public class Checklist : Activity
{
    private int _timesCompleteable;
    private int _timesCompleted;
    private int _incrementalPoints;
    public Checklist(string name, int pointValue, int timesCompleteable, int incrementalPoints) : base(name, pointValue)
    {
        _timesCompleteable = timesCompleteable;
        _timesCompleted = 0;
        _incrementalPoints = incrementalPoints;
    }
    public override int Complete()
    {
        _timesCompleted++;

        if (_timesCompleted < _timesCompleteable)
        {
            Console.WriteLine("Checklist activity completed " + _timesCompleted + " out of " + _timesCompleteable + " times.");
            Console.WriteLine("You earned " + _incrementalPoints + " points.");
            return _incrementalPoints;
        }
        else if (_timesCompleted == _timesCompleteable)
        {
            Console.WriteLine("Congratulations! You have completed the checklist activity the maximum number of times and earned " + _pointValue + " points!");
            return _pointValue;
        }
        else
        {
            Console.WriteLine("Checklist activity already completed the maximum number of times.");
            return 0;
        }
    }
    public override string IsCompleted()
    {
        if (_timesCompleted >= _timesCompleteable)
        {
            return $"{GetName()} [X] {_timesCompleted}/{_timesCompleteable}";
        }
        else
        {
            return $"{GetName()} [ ] {_timesCompleted}/{_timesCompleteable}";
        }
    }
    public override string GetTypeName()
    {
        return "Checklist";
    }
    public override string SaveData()
    {
        return $"{GetType()}|{GetName()}|{_pointValue}|{_timesCompleteable}|{_timesCompleted}|{_incrementalPoints}";
    }
}