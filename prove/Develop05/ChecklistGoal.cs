// ChecklistGoal.cs

class ChecklistGoal : Goal
{
    private int targetCount;
    private int completedCount;

    public ChecklistGoal(string name, int value, int targetCount) : base(name)
    {
        this.value = value;
        this.targetCount = targetCount;
        this.completedCount = 0;
    }

    public override void MarkComplete()
    {
        completedCount++;
        if (completedCount == targetCount)
        {
            Console.WriteLine($"Goal '{name}' completed! +{value} points (Bonus +500 points)");
        }
        else
        {
            Console.WriteLine($"Goal '{name}' completed! +{value} points");
        }
    }

    public override void DisplayProgress()
    {
        Console.WriteLine($"[{name}] - Completed: {completedCount}/{targetCount} times");
    }
}