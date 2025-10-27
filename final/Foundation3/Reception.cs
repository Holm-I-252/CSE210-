public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, DateTime date, DateTime time, string address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"Event Type: Reception\n{base.GetStandardDetails()}\nRSVP Email: {_rsvpEmail}";
    }

    public override string GetShortDescription()
    {
        return $"Event Type: Reception\nTitle: {_title}\nDate: {_date.ToString()}";
    }
}