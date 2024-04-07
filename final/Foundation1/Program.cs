using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of Comment, Video, and YouTubeManager
        Comment comment1 = new Comment("User1", "Great video!");
        Comment comment2 = new Comment("User2", "I learned a lot.");
        Comment comment3 = new Comment("User3", "Interesting content.");

        Video video1 = new Video("Introduction to OOP", "Codek", 300);
        video1.AddComment(comment1);
        video1.AddComment(comment2);

        Video video2 = new Video("C# Fundamentals", "CodeMaster", 400);
        video2.AddComment(comment3);

        YouTubeManager youTubeManager = new YouTubeManager();
        youTubeManager.AddVideo(video1);
        youTubeManager.AddVideo(video2);

        // Display video information
        youTubeManager.DisplayVideoInfo();
    }
}