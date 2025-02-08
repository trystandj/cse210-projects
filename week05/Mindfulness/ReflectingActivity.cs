using System;


class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

public void Run()
{
    DisplayStartingMessage();

  
    string prompt = GetRandomPrompt();
    Console.WriteLine($"\nPrompt: {prompt}");
    Console.WriteLine("Think about this for a few seconds...");
    ShowSpinner(5);

    
    Console.WriteLine("\nPress Enter when you're ready to view the reflection questions...");
    Console.ReadLine(); 

    Console.WriteLine("\nNow, reflect on the following questions:");
    ShowSpinner(5);
    Console.Clear();

    DateTime endTime = DateTime.Now.AddSeconds(_duration);
    while (DateTime.Now < endTime)
    {
        string question = GetRandomQuestion();
        Console.WriteLine($"\n{question}");
        ShowSpinner(10); 
    }

    Console.WriteLine("\nGreat job reflecting!");
    DisplayEndingMessage();
    ShowSpinner(10);
    Thread.Sleep(500);
    Console.Clear();
}


    public string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        return _questions[random.Next(_questions.Count)];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"Prompt: {GetRandomPrompt()}");
    }

    public void DisplayQuestions()
    {
        Console.WriteLine($"Question: {GetRandomQuestion()}");
    }
}
