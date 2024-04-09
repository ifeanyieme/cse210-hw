// Reception.cs
public class Reception : Event
{
    public string RsvpEmail { get; set; }

    public Reception(string title, string description, DateTime date, TimeSpan time, string address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        RsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}RSVP Email: {RsvpEmail}\n";
    }
}