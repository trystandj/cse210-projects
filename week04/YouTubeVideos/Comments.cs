using System;

class Comment
{
    private string _userName;
    private string _comment;

    public Comment(string userName, string comments) {
        _userName = userName;
        _comment = comments;
    }

    public string GetComment() {
        return $"{_userName}: {_comment}";
    }
}