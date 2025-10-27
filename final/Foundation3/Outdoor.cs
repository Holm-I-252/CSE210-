public class Outdoor : Event
{
    private string _weatherForecast;

    public Outdoor(string title, string description, DateTime date, DateTime time, string address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return $"Event Type: Outdoor\n{base.GetStandardDetails()}\nWeather Forecast: {_weatherForecast}";
    }

    public override string GetShortDescription()
    {
        return $"Event Type: Outdoor\nTitle: {_title}\nDate: {_date.ToString()}";
    }
}