using System;
using System.Threading;

class MindfulnessActivity
{
    protected int duration;

    public void StartActivity()
    {
        DisplayStartingMessage();
        SetDuration();
        PrepareToBegin();
        PerformActivity();
        DisplayEndingMessage();
        LogActivity();
    }

    protected virtual void DisplayStartingMessage()
    {
        Console.WriteLine("Standard starting message.");
    }

    protected virtual void SetDuration()
    {
        Console.Write("Enter the duration (in seconds): ");
        duration = Convert.ToInt32(Console.ReadLine());
    }

    protected virtual void PrepareToBegin()
    {
        Console.WriteLine("Prepare to begin...");
        
        Console.Write("+");

        Thread.Sleep(500);

        Console.Write("\b \b"); // Erase the + character
        Console.Write("-"); // Replace it with the - character
    }

    protected virtual void PerformActivity()
    {
        // To be implemented in derived classes
    }

    protected virtual void DisplayEndingMessage()
    {
        Console.WriteLine($"Good job! You have completed the activity for {duration} seconds.");
        Thread.Sleep(3000); // Pause for 3 seconds
        
        Console.Write("+");

        Thread.Sleep(500);

        Console.Write("\b \b"); // Erase the + character
        Console.Write("-"); // Replace it with the - character

    }

    protected virtual void LogActivity()
    {
        // Log activity details to a file
        using (StreamWriter writer = new StreamWriter("activity_log.txt", true))
        {
            writer.WriteLine($"{DateTime.Now}: Completed {GetType().Name} for {duration} seconds.");
        }
    }
}
