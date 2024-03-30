// Goal.cs

using System;

class Goal
{
    protected internal int value;
    protected internal string name; // Change access modifier to protected internal

    public Goal(string name)
    {
        this.name = name;
        this.value = 0;
    }

    public virtual void MarkComplete()
    {
        Console.WriteLine($"Goal '{name}' completed! +{value} points");
    }

    public virtual void DisplayProgress()
    {
        Console.WriteLine($"[{name}] - Completed: No");
    }
}