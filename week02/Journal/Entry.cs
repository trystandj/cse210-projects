using System;
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _goals;

    public void Display ()
    {
        if (!string.IsNullOrEmpty(_goals))
        {
            Console.WriteLine($"Date: {_date} - Goals: {_promptText}");
            Console.WriteLine($"Your Goals are: {_goals}");
        }
        if (!string.IsNullOrEmpty(_entryText))
        {
            Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
            Console.WriteLine($"Entry: {_entryText}");
        }
        Console.WriteLine();
    }

}