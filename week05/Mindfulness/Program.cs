using System;

class Program
{
    static void Main()
    {
        string choice = "";
        while (choice != "4") 
        {
            choice = DisplayMenu();
        }
    }

    public static string DisplayMenu() 
    {
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start Breathing Activity");
        Console.WriteLine("2. Start Reflecting Activity");
        Console.WriteLine("3. Start Listing Activity");
        Console.WriteLine("4. Quit");

        string choice = Console.ReadLine();


        if (choice == "1")
        {
            Console.Clear();
            BreathingActivity breathingActivity = new BreathingActivity();
            breathingActivity.Run();
        }
        else if (choice == "2") 
        {
            Console.Clear();
            ReflectingActivity reflectingActivity = new ReflectingActivity();
            reflectingActivity.Run();
        }
        else if (choice == "3")
        {
            Console.Clear();
            ListingActivity listingActivity = new ListingActivity();
            listingActivity.Run();
        }
        else if (choice == "4")
        {
            Console.WriteLine("Goodbye!");
        }
        else
        {
            Console.WriteLine("Invalid Choice, please try again.");
        }

        return choice;
    }
}
