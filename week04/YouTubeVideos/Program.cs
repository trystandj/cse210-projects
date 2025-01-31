using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Man Fights Bear", "Grizzly", 35);
        Video video2 = new Video("How to Code like a Pro", "CodeGeek", 100);
        Video video3 = new Video("How to Make Cookies", "ProChef", 50);

        video1.AddComment("Micah","This is a great video!");
        video1.AddComment("Jane","How did you get so close to the bear?");
        video1.AddComment("Alice","Not the bear!");

        video2.AddComment("John","How did you learn to code like that?");
        video2.AddComment("Joe","Can you teach me how to code?");
        video2.AddComment("Emily","I wish I could code like you.");

        video3.AddComment("Mike","Do you have any other recipes?");
        video3.AddComment("Dom","Those look so good!");
        video3.AddComment("Alek","Can't wait to try this recipe!");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.GetDisplay();
            Console.WriteLine();
        }
    }
}