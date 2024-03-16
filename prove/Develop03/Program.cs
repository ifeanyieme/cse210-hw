using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        // Creativity and Exceeding Requirements:
        // - Added support for a library of scriptures loaded from a file.
        // - Enhanced the program to handle additional challenges by introducing a timer for each scripture.
        // - The program now provides feedback on the time taken to memorize each scripture.
        
        // Load scriptures from a file
        List<Scripture> scriptureLibrary = LoadScripturesFromFile("scripture_library.txt");

        foreach (var scripture in scriptureLibrary)
        {
            RunScriptureMemorization(scripture);
        }
    }

    static List<Scripture> LoadScripturesFromFile(string filePath)
    {
        List<Scripture> scriptures = new List<Scripture>();

        try
        {
            // Read all lines from the file
            string[] lines = File.ReadAllLines(filePath);

            // Process each line to extract reference and text
            foreach (var line in lines)
            {
                string[] parts = line.Split('|');

                if (parts.Length == 2)
                {
                    // Create a new scripture object and add it to the library
                    scriptures.Add(new Scripture(parts[0].Trim(), parts[1].Trim()));
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error loading scriptures from file: {e.Message}");
        }

        return scriptures;
    }

    static void RunScriptureMemorization(Scripture scripture)
    {
        // Run the program for each scripture
        Console.WriteLine($"Memorize the following scripture: {scripture}");
        Console.WriteLine("Press Enter to start...");

        // Wait for the user to press Enter
        Console.ReadLine();

        // Create a stopwatch to measure the time taken
        System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
        stopwatch.Start();

        // Run the program
        while (scripture.HasHiddenWords())
        {
            Console.Clear();
            scripture.Display();

            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
                break;

            scripture.HideRandomWords();
        }

        // Stop the stopwatch and display the time taken
        stopwatch.Stop();
        Console.WriteLine($"You took {stopwatch.Elapsed.TotalSeconds:F2} seconds to memorize {scripture}\n");
    }
}

class Scripture
{
    private readonly ScriptureReference reference;
    private readonly List<ScriptureWord> words;

    public Scripture(string referenceText, string scriptureText)
    {
        reference = new ScriptureReference(referenceText);
        words = CreateWords(scriptureText);
    }

    private List<ScriptureWord> CreateWords(string scriptureText)
    {
        string[] wordArray = scriptureText.Split(' ');
        return wordArray.Select(word => new ScriptureWord(word)).ToList();
    }

    public void Display()
    {
        Console.WriteLine($"{reference}: {GetVisibleText()}");
    }

    public void HideRandomWords()
    {
        foreach (ScriptureWord word in words)
        {
            if (word.IsVisible && (new Random().Next(2) == 0)) // Randomly decide to hide the word
            {
                word.Hide();
                break;
            }
        }
    }

    private string GetVisibleText()
    {
        return string.Join(" ", words.Select(word => word.IsVisible ? word.Text : "***"));
    }

    public bool HasHiddenWords()
    {
        return words.Any(word => word.IsVisible);
    }
}

class ScriptureReference
{
    private readonly string text;

    public ScriptureReference(string referenceText)
    {
        text = referenceText;
    }

    public override string ToString()
    {
        return text;
    }
}

class ScriptureWord
{
    public string Text { get; }
    public bool IsVisible { get; private set; }

    public ScriptureWord(string word)
    {
        Text = word;
        IsVisible = true;
    }

    public void Hide()
    {
        IsVisible = false;
    }
}
