// User.cs

using System;
using System.Collections.Generic;

class User
{
    private List<Goal> goals = new List<Goal>();
    private int totalScore = 0;

    public List<Goal> Goals { get { return goals; } }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(Goal goal)
    {
        goal.MarkComplete();
        totalScore += goal.value;
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\n--- Your Goals ---");
        foreach (var goal in goals)
        {
            goal.DisplayProgress();
        }
        Console.WriteLine($"Total Score: {totalScore}\n");
    }
}