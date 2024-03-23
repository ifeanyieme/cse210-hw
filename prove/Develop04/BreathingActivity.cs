class BreathingActivity : MindfulnessActivity
{
    protected override void DisplayStartingMessage()
    {
       
        Console.WriteLine();
        Console.WriteLine("DESCRIPTION: This activity will help you relax by walking you through breathing in and out slowly. \nClear your mind and focus on your breathing.");
        Console.WriteLine();
        
    }

    protected override void PerformActivity()
    {
        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine("> Breathe in...");
            Thread.Sleep(5000); // Pause for 2 seconds
            Console.Write("\b \b"); // Erase the "Breathe in..." text
            Console.WriteLine("> Breathe out...");
            Thread.Sleep(5000); // Pause for 2 seconds
            Console.Write("\b \b"); // Erase the "Breathe out..." text
            Console.WriteLine();
        
        }
    }
}
