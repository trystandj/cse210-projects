// To show creativity I have included a feature that allows the user to write their goals in the journal. 
// Additionally, those goals will be saved and loaded alongside the journal entries.
// I used https://www.geeksforgeeks.org/c-sharp-isnullorempty-method/ this site to learn more about how IsNullOrEmpty() works and how I employed it to help with getting null and empty strings back from loading saved text files.

using System;


class Program
{
    static void Main()
    {
        string choice = "";
        Journal journal = new Journal();

        while (choice != "6")
        {
            choice = DisplayMenu(journal);
        }
    }

    public static string DisplayMenu(Journal journal)
    {
        Console.WriteLine();
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write a Journal Entry");
        Console.WriteLine("2. Write Goals");
        Console.WriteLine("3. Display");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Save");
        Console.WriteLine("6. Quit");
        Console.Write("What would you like to do? ");

        string choice = Console.ReadLine();
        PromptGenerator generator = new PromptGenerator();

        if (choice == "1")
        {
            string promptText = generator.GetRandomPrompt();
            Console.WriteLine(promptText);
            Console.Write("Entry: ");
            string entryText = Console.ReadLine();
            string date = DateTime.Now.ToString("MM/dd/yyyy");

            Entry newEntry = new Entry{
                _date = date,
                _promptText = promptText,
                _entryText = entryText
            };

            journal.AddEntry(newEntry);
            
        }
        else if (choice == "2") {
            Console.WriteLine("What are your goal/s?");
            string goals = Console.ReadLine();
            string date = DateTime.Now.ToString("MM/dd/yyyy");

            Entry newEntry = new Entry{
                _date = date,
                _goals = goals
            };

            journal.AddEntry(newEntry);
        }
        else if (choice == "3")
        {
            journal.DisplayAll();
        }

        else if (choice == "4") {
            Console.WriteLine("What is the filename?");
            string filename = Console.ReadLine();
            journal.LoadFromFile(filename);
            journal.DisplayAll();
        }

        else if (choice == "5") {
            Console.WriteLine("What is the filename?");
            string filename = Console.ReadLine();
            journal.SaveToFile(filename);
            
        }

        else if (choice == "6")
        {
            Console.WriteLine("Goodbye!");
        }

        else if (choice == "")
        {
            Console.WriteLine($"Invalid Choice");
        }


        return choice;
    }

} 