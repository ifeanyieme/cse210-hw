// YouTubeManager.cs
using System;
using System.Collections.Generic;

public class YouTubeManager
{
    public List<Video> Videos { get; set; } = new List<Video>();

    public void AddVideo(Video video)
    {
        Videos.Add(video);
    }

    public void DisplayVideoInfo()
    {
        foreach (var video in Videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"  {comment}");
            }
            Console.WriteLine();
        }
    }
}