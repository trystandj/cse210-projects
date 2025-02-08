using System;

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "Helps you relax by guiding your breathing")
    {
    }

    public void Run()
    {

        DisplayStartingMessage();

        Console.WriteLine("\nLet's begin the breathing exercise...");
        ShowSpinner(5);
        Thread.Sleep(1000);
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(3);  
            Console.Clear();

            
            Console.Write("Breathe out... ");
            ShowCountDown(3);  
            Console.Clear();
        }

        DisplayEndingMessage();
        ShowSpinner(5);
        Thread.Sleep(500);
        Console.Clear();
    }
}
