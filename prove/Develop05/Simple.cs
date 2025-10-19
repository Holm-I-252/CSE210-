public class Simple : Activity
{
    protected bool _isCompleted;
    public Simple(string name, int pointValue) : base(name, pointValue)
    {
        _isCompleted = false;
    }
    public override int Complete()
    {
        if (!_isCompleted)
        {
            _isCompleted = true;
            return _pointValue;
        }
        else
        {
            Console.WriteLine("Activity already completed.");
            return 0;
        }
    }

    public override string IsCompleted()
    {
        if (_isCompleted)
        {
            return $"{GetName()} [X]";
        }
        else
        {
            return $"{GetName()} [ ]";
        }
    }

    public override string GetTypeName()
    {
        return "Simple";
    }
    
    public override string SaveData()
    {
        return $"{GetType()}|{GetName()}|{_pointValue}|{_isCompleted}";
    }
}