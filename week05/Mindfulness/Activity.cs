using System;

class Activity 
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name; 
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\n{_name} - {_description}\n");
        Console.WriteLine("How long would you like to spend on this activity? (in seconds)");

        string input = Console.ReadLine();

        bool isNumber = int.TryParse(input, out int result);
        if (isNumber && result > 0)
        {
            _duration = result;
            Console.Clear();
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
            DisplayStartingMessage(); 
        }
    }

    public void DisplayEndingMessage() {
        Console.WriteLine("Well Done!!!");
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the reflecting activity. ");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>
        {
            "|", "/", "-", "\\", "|"
        };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }
    
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\b{i}");  
            System.Threading.Thread.Sleep(1000); 
        }
        Console.WriteLine("\n"); 
    }
}