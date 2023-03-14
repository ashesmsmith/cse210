using System;

public class Video
{
    // ATTRIBUTES
    private string _title;
    private string _author;
    private double _length;

    public List<Comment> _comments = new List<Comment>();

    // CONSTRUCTORS
    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    // METHODS
    public int CommentCount()
    {
        int count = _comments.Count();
        return count;
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"{_title}");
        Console.WriteLine($"{_author} - {_length} seconds");
        Console.WriteLine($"{CommentCount()} comments");
        Console.WriteLine("");

        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }

        Console.WriteLine("");
    }
}