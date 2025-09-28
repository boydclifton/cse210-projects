using System;
using System.Collections.Generic;


public class Video
{
    private string _videoTitle;
    private string _videoAuthor;
    private int _lengthInSeconds;
    private List<Comment> _comments = new List<Comment>();

    public Video(string videoTitle, string videoAuthor, int lengthInSeconds)
    {
        _videoTitle = videoTitle;
        _videoAuthor = videoAuthor;
        _lengthInSeconds = lengthInSeconds;

    }

    public string DisplayDetails()
    {
        return $"Title: {_videoTitle}, Author: {_videoAuthor}, Length: {_lengthInSeconds} seconds";
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }
}