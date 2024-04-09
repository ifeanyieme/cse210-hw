// Lecture.cs
public class Lecture : Event
{
    public string Speaker { get; set; }
    public int Capacity { get; set; }

    public Lecture(string title, string description, DateTime date, TimeSpan time, string address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        Speaker = speaker;
        Capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}Speaker: {Speaker}\nCapacity: {Capacity}\n";
    }
}