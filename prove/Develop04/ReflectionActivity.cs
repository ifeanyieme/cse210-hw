class ReflectionActivity : MindfulnessActivity
{
    private List<string> usedPrompts = new List<string>();
    private string[] prompts = {
        "> Think of a time when you stood up for someone else.",
        "> Think of a time when you did something really difficult.",
        "> Think of a time when you helped someone in need.",
        "> Think of a time when you did something truly selfless."
    };

    protected override void DisplayStartingMessage()
    {
        Console.WriteLine("\nStarting Reflection Activity.");
        Console.WriteLine("Description: This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    protected override void PerformActivity()
    {
        Random random = new Random();

        while (usedPrompts.Count < prompts.Length)
        {
            string randomPrompt = GetUnusedRandomPrompt(random);
            Console.WriteLine($"\nReflect on: {randomPrompt}");

            foreach (string question in GetReflectiveQuestions())
            {
                Console.WriteLine(question);
                Thread.Sleep(3000); // Pause for 3 seconds
                // Display spinner or any animation here
            }
        }
    }

    private string GetUnusedRandomPrompt(Random random)
    {
        string randomPrompt;
        do
        {
            randomPrompt = prompts[random.Next(prompts.Length)];
        } while (usedPrompts.Contains(randomPrompt));

        usedPrompts.Add(randomPrompt);
        return randomPrompt;
    }

    private string[] GetReflectiveQuestions()
    {
        // Return an array of reflective questions
        return new string[]
        {
            "> Why was this experience meaningful to you?",
            "> Have you ever done anything like this before?",
            "> How did you get started?",
            "> How did you feel when it was complete?",
            "> What made this time different than other times when you were not as successful?",
            "> What is your favorite thing about this experience?",
            "> What could you learn from this experience that applies to other situations?",
            "> What did you learn about yourself through this experience?",
            "> How can you keep this experience in mind in the future?"
        };
    }
}
