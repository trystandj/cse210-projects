using System;
using System.Collections.Generic;

class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length) {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(string userName, string comment) {
        _comments.Add(new Comment(userName, comment));
    }

    public void GetDisplay() {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length}");
        Console.WriteLine("Comments:");
        foreach (var comment in _comments) {
            Console.WriteLine(comment.GetComment());
        }
    }
}