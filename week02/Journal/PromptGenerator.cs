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
            _prompts.Add("How do you feel about your goals right now?");
            _prompts.Add("What are you struggling with?");
            _prompts.Add("What goals would you like to set for this week?");   
            _prompts.Add("How do people view you and how would you like them to see you?");  
            _prompts.Add("How did you see God's hand today?");
        }
    }
    
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

}