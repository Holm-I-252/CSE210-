public class Swimming : Activity
{
    private double _laps;

    public Swimming(int duration, DateTime date, double laps)
        : base(duration, date)
    {
        _laps = laps;
        base.SetType("Swimming");
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / base.GetDuration()) * 60;
    }
    public override double GetPace()
    {
        return base.GetDuration() / GetDistance();
    }
}