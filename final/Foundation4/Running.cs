public class Running : Activity
{
    private double _distance;

    public Running(int duration, DateTime date, double distance)
        : base(duration, date)
    {
        _distance = distance;
        base.SetType("Running");
    }
    
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / base.GetDuration()) * 60;
    }

    public override double GetPace()
    {
        return base.GetDuration() / _distance;
    }
}