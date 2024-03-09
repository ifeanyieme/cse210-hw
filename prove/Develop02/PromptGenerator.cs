using System;

class PromptGenerator
{
    public List<string> prompts;

    public PromptGenerator()
    {
        // Initialize with some example prompts
        prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "Describe a moment that made you smile today.",
            "What is something new you learned today?",
            "Write about a goal you want to achieve in the next week.",
            "Reflect on a challenge you faced and how you overcame it.",
            "Share a quote that resonated with you today.",
            "Write about a place you would like to visit and why.",
            "If you could have dinner with any historical figure, who would it be and why?",
            "Write about a hobby or activity that brings you joy.",
            "What is something you are grateful for today?",
            "Describe a random act of kindness you witnessed or performed.",
            "Reflect on a book, movie, or song that left an impact on you recently.",
            "If you could time travel, which era would you visit and why?",
            "Write about a skill you want to develop in the coming months.",
            "What is a small, positive change you can make in your daily routine?",
            "Reflect on a moment that challenged your beliefs and how you responded.",
        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}
