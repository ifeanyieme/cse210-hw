class ListingActivity : MindfulnessActivity
{
    private List<string> usedPrompts = new List<string>();
    private string[] prompts = {
        "> Who are people that you appreciate?",
        "> What are personal strengths of yours?",
        "> Who are people that you have helped this week?",
        "> When have you felt the Holy Ghost this month?",
        "> Who are some of your personal heroes?"
    };

    private List<string> listedItems = new List<string>();

    protected override void DisplayStartingMessage()
    {
        Console.WriteLine("\nStarting Listing Activity.");
        Console.WriteLine();
        Console.WriteLine("DESCRIPTIO: This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    protected override void PerformActivity()
    {
        Random random = new Random();

        string randomPrompt = GetUsedRandomPrompt(random);
        Console.WriteLine($"List as many as you can about: {randomPrompt}");

        // Countdown before listing
        Console.WriteLine("Get ready to list...");
        
        Console.Write("+");

        Thread.Sleep(500);

        Console.Write("\b \b"); // Erase the + character
        Console.Write("-"); // Replace it with the - character

        Thread.Sleep(5000); // Pause for 5 seconds

        // Simulate user listing items
        for (int i = 1; i <= duration; i++)
        {
            string listItem = $"Item {i}";
            Console.WriteLine(listItem);
            Thread.Sleep(1000); // Pause for 1 second
            listedItems.Add(listItem);
            // Display spinner or any animation here
        }
    }

    private string GetUsedRandomPrompt(Random random)
    {
        throw new NotImplementedException();
    }

    protected override void DisplayEndingMessage()
    {
        base.DisplayEndingMessage();
        Console.WriteLine($"You listed {duration} items. Here they are:");
        foreach (var item in listedItems)
        {
            Console.WriteLine(item);
        }
    }

    protected override void LogActivity()
    {
        base.LogActivity();

        // Log listed items to a file
        using (StreamWriter writer = new StreamWriter("listed_items_log.txt", true))
        {
            writer.WriteLine($"{DateTime.Now}: {GetType().Name} - Listed {duration} items.");
            foreach (var item in listedItems)
            {
                writer.WriteLine(item);
            }
        }
    }
}
