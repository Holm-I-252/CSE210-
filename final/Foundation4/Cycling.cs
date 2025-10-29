public class Cycling : Activity
{
    private double _speed;

    public Cycling(int duration, DateTime date, double speed)
        : base(duration, date)
    {
        _speed = speed;
        base.SetType("Cycling");
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override double GetDistance()
    {
        return (_speed * base.GetDuration()) / 60;
    }
}