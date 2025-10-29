public class Activity
{
    private int _duration;
    private DateTime _date;
    private string _type;
    public Activity(int duration, DateTime date)
    {
        _duration = duration;
        _date = date;
        _type = "N/A";
    }

    public int GetDuration()
    {
        return _duration;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public void SetType(string type)
    {
        _type = type;
    }

    public void GetSummary()
    {
        Console.WriteLine($"{_date.ToShortDateString()} {_type} ({_duration} min) - Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} km/h, Pace: {GetPace():F2} min/km");
    }

    public virtual double GetDistance()
    {
        return 0.0;
    }

    public virtual double GetSpeed()
    {
        return 0.0;
    }
    
    public virtual double GetPace()
    {
        return 0.0;
    }
}
