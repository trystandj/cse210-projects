using System;

class Program
{
    static void Main(string[] args)
    {
        var activities = new List<Activity>
        {
            new Running("03 Nov 2022", 30, 3),
            new Bicycles("03 Nov 2022", 30, 12),
            new Swimming("03 Nov 2022", 30, 20)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}