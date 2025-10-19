public class Eternal : Activity
{
    public Eternal(string name, int pointValue) : base(name, pointValue)
    {
    }

    public override int Complete()
    {
        Console.WriteLine("Eternal activity completed. You earned " + _pointValue + " points.");
        Console.WriteLine("You can complete eternal activities again for more points!");
        return _pointValue;
    }

    public override string IsCompleted()
    {
        return $"{GetName()} [E]";
    }
    public override string GetTypeName()
    {
        return "Eternal";
    }
    public override string SaveData()
    {
        return $"{GetType()}|{GetName()}|{_pointValue}";
    }
}