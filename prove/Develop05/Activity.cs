public class Activity
{
    private string _name;
    protected int _pointValue;
    public Activity(string name, int pointValue)
    {
        _name = name;
        _pointValue = pointValue;
    }

    public string GetName()
    {
        return _name;
    }
    public int GetPointValue()
    {
        return _pointValue;
    }

    public virtual int Complete()
    {
        return _pointValue;
    }

    public virtual string IsCompleted()
    {
        return "";
    }

    public virtual string GetTypeName()
    {
        return "";
    }

    public virtual string SaveData()
    {
        return "";
    }

}