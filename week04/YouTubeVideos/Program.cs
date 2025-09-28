using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Funny Joy Riding", "PewDiePie", 300);
        video1.AddComment(new Comment("Jake", "This is hilarious!"));
        video1.AddComment(new Comment("Rufus", "What did I just watch?"));
        video1.AddComment(new Comment("Brenda", "This was so confusing."));

        Video video2 = new Video("Learn C# in 10 Minutes", "CodeAcademy", 600);
        video2.AddComment(new Comment("Alice", "Great tutorial, very clear!"));
        video2.AddComment(new Comment("Wesley", "Excellent tutorial."));
        video2.AddComment(new Comment("John", "lol I understood nothing."));

        Video video3 = new Video("The basics of longboarding", "SkaterDude54", 450);
        video3.AddComment(new Comment("Ryan", "Throwback to the 90s!"));
        video3.AddComment(new Comment("Kelly", "I've always wanted to try this."));
        video3.AddComment(new Comment("Joshua", "This video deserves more views!"));

        List<Video> _videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in _videos)
        {
            Console.WriteLine($"{video.DisplayDetails()}");
            Console.WriteLine($"Comments: {video.GetNumberOfComments()}");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(comment.DisplayComment());
            }
            Console.WriteLine(new string('-', 40));
        }
    }
}