// Display.cs
using System;
using System.Collections.Generic;

public class Display
{
    // Method to display details of a list of videos
    public void DisplayVideos(List<Video> videos)
    {
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");

            // Display each comment for the video
            foreach (var comment in video.GetComments())
            {
                comment.DisplayComment();
            }
        }
    }
}
