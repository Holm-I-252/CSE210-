public class Event
{
    protected string _title;
    protected string _description;
    protected DateTime _date;
    protected DateTime _time;
    protected string _address;

    public Event(string title, string description, DateTime date, DateTime time, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date.ToString()}\nTime: {_time.ToString()}\nAddress: {_address}";
    }
    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }
    public virtual string GetShortDescription()
    {
        return GetStandardDetails();
    }
}