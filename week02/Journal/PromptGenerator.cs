using System;
using System.Collections.Generic;
public class PromptGenerator
{

    public List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>(); {
            _prompts.Add("What did you learn today?");
            _prompts.Add("What was the most challenging part of your day?");
            _prompts.Add("What are you grateful for?");
            _prompts.Add("What are you looking forward to?");
            _prompts.Add("What are you feeling right now?");
        }
    }
    
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

}