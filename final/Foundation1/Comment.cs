// Comment.cs

public class Comment
{
    public string CommenterName { get; set; }
    public string CommentText { get; set; }

    public Comment(string commenterName, string commentText)
    {
        CommenterName = commenterName;
        CommentText = commentText;
    }

    // Method to display the comment details
    public void DisplayComment()
    {
        Console.WriteLine($"Commenter: {CommenterName}");
        Console.WriteLine($"Comment: {CommentText}\n");
    }
}
