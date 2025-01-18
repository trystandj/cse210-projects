using System;


class Program
{
    static void Main()
    {
        string choice = "";
        Journal journal = new Journal();

        while (choice != "5")
        {
            choice = DisplayMenu(journal);
        }
    }

    public static string DisplayMenu(Journal journal)
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
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
            journal.SaveToFile("journal.txt");
        }
        else if (choice == "2")
        {
            journal.DisplayAll();
        }

        else if (choice == "3") {
            Console.WriteLine("What is the filename?");
            string filename = Console.ReadLine();
            journal.LoadFromFile(filename);
            journal.DisplayAll();
        }

        else if (choice == "4") {
            Console.WriteLine("What is the filename?");
            string filename = Console.ReadLine();
            journal.SaveToFile(filename);
        }

        else if (choice == "5")
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