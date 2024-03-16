using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
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
