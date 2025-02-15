using System;
using System.Collections.Generic;

class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager() { 
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool quit = false;
        while (!quit)
        {
            Console.Clear();
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Display Score");
            Console.WriteLine("  7. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalNames();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
            else if (choice == "6")
            {
                DisplayPlayerInfo();
            }
            else if (choice == "7")
            {
                quit = true;
            }
            else
            {
                Console.WriteLine("Invalid choice. Press any key to continue...");
                Console.ReadKey();
            }
        }
    }

    public void DisplayPlayerInfo() {
        Console.WriteLine($"You currently have {_score} points.");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
     }
    public void ListGoalNames() {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
                }
        Console.WriteLine("Press any key to continue...");
     }
    public void ListGoalDetails() { }
    public void CreateGoal() { }
    public void RecordEvent() { }
    public void SaveGoals() { }
    public void LoadGoals() { }
}