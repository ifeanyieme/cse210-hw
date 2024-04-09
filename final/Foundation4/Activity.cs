// Activity.cs

using System;

public class Activity
{
    private DateTime date;
    protected int durationMinutes;

    public Activity(DateTime date, int durationMinutes)
    {
        this.date = date;
        this.durationMinutes = durationMinutes;
    }

    public virtual double GetDistance()
    {
        // Base class may not have a direct calculation, so return a default value.
        return 0.0;
    }

    public virtual double GetSpeed()
    {
        // Base class may not have a direct calculation, so return a default value.
        return 0.0;
    }

    public virtual double GetPace()
    {
        // Base class may not have a direct calculation, so return a default value.
        return 0.0;
    }

    public virtual string GetSummary()  // Mark as virtual
    {
        return $"{date.ToShortDateString()} - {GetType().Name} ({durationMinutes} min)";
    }
}