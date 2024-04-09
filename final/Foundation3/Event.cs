// Event.cs
using System;

public class Event
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan Time { get; set; }
    public string Address { get; set; }

    public Event(string title, string description, DateTime date, TimeSpan time, string address)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        Address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {Title}\nDescription: {Description}\nDate: {Date.ToShortDateString()} Time: {Time}\nAddress: {Address}\n";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public string GetShortDescription()
    {
        return $"{GetType().Name}: {Title} - {Date.ToShortDateString()}";
    }
}