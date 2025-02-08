using System;

class ListingActivity : Activity {

    private int _count;
    private List<string>_prompts;

    public ListingActivity() : base("Listing Activity", "List as many things as you can based on the given prompt.")
    {
        _prompts = new List<string>
        {
            "List some times you felt the spirit",
            "List some times where the Lord has answered your prayer",
            "List some activities that make you happy",
            "List some of your personal achievements",
            "List some of your favorite things"
            
        };
    }



    public void Run(){
        DisplayStartingMessage();
        Console.WriteLine(GetRandomPrompt());

        List<string> userResponses = GetListFromUser();

        _count = userResponses.Count;

        Console.WriteLine($"You listed {_count} items! Well done.");
        DisplayEndingMessage();
        ShowSpinner(10);
        Thread.Sleep(500);
        Console.Clear();
    }

    public string GetRandomPrompt()
    {
       Random random = new Random();
       int index = random.Next(_prompts.Count);
       return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();

        Console.WriteLine($"You have {_duration} seconds to list as many items as you can.");
        ShowSpinner(10);
        Thread.Sleep(500);
        Console.WriteLine("Start now!");
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
         while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                responses.Add(input);
            }
        }

        Console.WriteLine("Time's up!");
        return responses;
    }
}