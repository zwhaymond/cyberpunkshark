// Program.cs
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Create a list of videos
        List<Video> videos = new List<Video>();

        // Create video objects
        Video video1 = new Video("How to Code in C#", "John Doe", 300);
        Video video2 = new Video("Exploring the Solar System", "Jane Smith", 600);
        Video video3 = new Video("Cooking 101", "Chef Alex", 1200);

        // Add comments to video1
        video1.AddComment(new Comment("Alice", "Great video! Very informative."));
        video1.AddComment(new Comment("Bob", "I love the examples, thanks!"));
        video1.AddComment(new Comment("Charlie", "Can you explain more about variables?"));

        // Add comments to video2
        video2.AddComment(new Comment("David", "Awesome video, loved the space facts."));
        video2.AddComment(new Comment("Eve", "What a fantastic explanation of the planets!"));

        // Add comments to video3
        video3.AddComment(new Comment("Frank", "This recipe is so simple and delicious."));
        video3.AddComment(new Comment("Grace", "Thanks for the tips, I will try this recipe!"));
        video3.AddComment(new Comment("Hannah", "Can't wait to cook this over the weekend."));
        video3.AddComment(new Comment("Ivy", "I tried this, and it turned out great!"));

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Create an instance of the Display class
        Display display = new Display();

        // Display information for each video
        display.DisplayVideos(videos);
    }
}
