using System;
using System.Collections.Generic;


public class Comment
{

    private string _commenter;
    private string _commentText;


    public Comment(string commenter, string commentText  ) {
        _commenter = commenter;
        _commentText = commentText;
    }

    public string DisplayComment()
    {
        return $"{_commenter}: {_commentText}";
    }

}