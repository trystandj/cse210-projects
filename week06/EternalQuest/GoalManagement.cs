using System;
using System.Collections.Generic;
using System.IO;
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
            if (_score > 20000)
                {
                    Console.WriteLine($"[GOLD] You currently have {_score} points.");
                    Console.WriteLine("Congrats on getting past 20,000 points! You are now in the Gold tier");
                }
                else if (_score > 10000)
                {
                    Console.WriteLine($"[Silver] You currently have {_score} points.");
                    Console.WriteLine("Congrats on getting past 10,000 points! You are now in the Silver tier");
                }
                else if (_score > 1000)
                {
                    Console.WriteLine($"[Bronze] You currently have {_score} points.");
                    Console.WriteLine("Congrats on getting past 1,000 points! You are now in the Bronze tier");
                }
                else
                {
                    Console.WriteLine($"You currently have {_score} points.");
                }
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
                Console.WriteLine("What is the filename? (goal.txt) ");
                string filename = Console.ReadLine();
                LoadGoals(filename);
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
                Console.Clear();
            }
        }
    }

    public void DisplayPlayerInfo() {
                
        if (_score > 20000)
        {
            Console.WriteLine($"[GOLD] You currently have {_score} points.");
            Console.WriteLine("Congrats on getting past 20,000 points! You are now in the Gold tier");
        }
        else if (_score > 10000)
        {
            Console.WriteLine($"[Silver] You currently have {_score} points.");
            Console.WriteLine("Congrats on getting past 10,000 points! You are now in the Silver tier");
        }
        else if (_score > 1000)
        {
            Console.WriteLine($"[Bronze] You currently have {_score} points.");
            Console.WriteLine("Congrats on getting past 1,000 points! You are now in the Bronze tier");
        }
        else
        {
            Console.WriteLine($"You currently have {_score} points.");
        }

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
     }
    public void ListGoalNames() {
    if (_goals.Count == 0)
                {
                    Console.WriteLine("No goals have been created yet.");
                }
                else
                {
                    Console.WriteLine("The goals are:");
                    for (int i = 0; i < _goals.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
                    }
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
     }
    public void ListGoalDetails() {
        if (_goals.Count == 0)
            {
                Console.WriteLine("No goals have been created yet.");
            }
            else
            {
                Console.WriteLine("The goals are:");
                for (int i = 0; i < _goals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
                }
            }
     }
    public void CreateGoal() {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        string choice = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of ponts? ");
        int.TryParse(Console.ReadLine(), out int points);
        
        Goal newGoal = null;
        
        if (choice == "1")
        {
            newGoal = new SimpleGoal(name, description, points);
        }
        else if (choice == "2")
        {
            newGoal = new EternalGoal(name, description, points);
        }
        else if (choice == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            if (int.TryParse(Console.ReadLine(), out int target))
            {
                Console.Write("What is the bonus for accomplishing it that many times? ");
                if (int.TryParse(Console.ReadLine(), out int bonus))
                {
                    newGoal = new ChecklistGoal(name, description, points, target, bonus);
                }
            }
            if (newGoal == null)
            {
                Console.WriteLine("Invalid input for target or bonus. Goal creation canceled.");
            }
        }
        else
        {
            Console.WriteLine("Invalid choice. Goal creation canceled.");
        }

        if (newGoal != null)
        {
            _goals.Add(newGoal);
            Console.WriteLine("Goal created successfully!");
        }
    }
    
    public void RecordEvent() {
        if (_goals.Count == 0){
            Console.WriteLine("No goals have been made yet");
        }
        else{
            Console.WriteLine("The goals are:");
            ListGoalDetails();
            Console.WriteLine("Which goal did you finish? ");

            if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= _goals.Count){
                Goal goal = _goals[index - 1];
                goal.RecordEvent();
                
                
                if (int.TryParse(goal.GetPoints().ToString(), out int points)){
                    _score += points;
                    Console.WriteLine($"Congrats! You have earned {points} points!");

                    if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete()){
                        int bonus = checklistGoal.GetBonus();
                        _score += bonus;
                         Console.WriteLine($"You also earned a bonus of {bonus} points!");
                    }
                    if (_score > 20000)
                    {
                        Console.WriteLine($"[GOLD] You currently have {_score} points.");
                        Console.WriteLine("Congrats on getting past 20,000 points! You are now in the Gold tier");
                    }
                    else if (_score > 10000)
                    {
                        Console.WriteLine($"[Silver] You currently have {_score} points.");
                        Console.WriteLine("Congrats on getting past 10,000 points! You are now in the Silver tier");
                    }
                    else if (_score > 1000)
                    {
                        Console.WriteLine($"[Bronze] You currently have {_score} points.");
                        Console.WriteLine("Congrats on getting past 1,000 points! You are now in the Bronze tier");
                    }
                    else
                    {
                        Console.WriteLine($"You currently have {_score} points.");
                    }

                }
            }
            else
                {
                    Console.WriteLine("Invalid goal number.");
                }
        }
        Console.WriteLine("Press any key to continue...");
        Console.Clear();
     }
public void SaveGoals()
{
    Console.Write("Enter filename to save goals (e.g., goals.txt): ");
    string filename = Console.ReadLine()?.Trim();

    if (string.IsNullOrWhiteSpace(filename))
    {
        Console.WriteLine("Invalid filename. Saving canceled.");
        Console.ReadKey();
        return;
    }

    
    if (!filename.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
    {
        filename += ".txt";
    }

    
    string directoryPath = Directory.GetCurrentDirectory();

  
    string fullPath = Path.Combine(directoryPath, filename);

    try
    {
        using (StreamWriter writer = new StreamWriter(fullPath))
        {
            writer.WriteLine(_score); 
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine($"Goals successfully saved to: {fullPath}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error saving file: {ex.Message}");
    }

    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
    Console.Clear();
}





public void LoadGoals(string filename)
{
    
    string directoryPath = Directory.GetCurrentDirectory();

   
    string fullPath = Path.Combine(directoryPath, filename);

    if (File.Exists(fullPath))
    {
        _goals.Clear(); 

        string[] lines = File.ReadAllLines(fullPath); 
        foreach (string line in lines)
        {
          
            if (string.IsNullOrWhiteSpace(line)) continue;

            string[] parts = line.Split(','); 
            if (lines.Length > 0) {
                    if (int.TryParse(lines[0].Trim(), out int parsedScore))
                        {
                        _score = parsedScore;  
                        if (_score > 20000)
                        {
                            Console.WriteLine($"[GOLD] You currently have {_score} points.");
                           
                        }
                        else if (_score > 10000)
                        {
                            Console.WriteLine($"[Silver] You currently have {_score} points.");
                            
                        }
                        else if (_score > 1000)
                        {
                            Console.WriteLine($"[Bronze] You currently have {_score} points.");
                            
                        }
                        else
                        {
                            Console.WriteLine($"You currently have {_score} points.");
                        }

                        }
            }
            if (parts.Length < 4) 
            {
                Console.WriteLine($"Skipping invalid line: {line}");
                continue; 
            }

            string goalType = parts[0].Trim(); 
            string name = parts[1].Trim(); 
            string description = parts[2].Trim(); 
            int points = int.TryParse(parts[3], out int parsedPoints) ? parsedPoints : 0;

            Goal newGoal = null; 

            if (goalType == "SimpleGoal")
            {
               
                newGoal = new SimpleGoal(name, description, points);
                Console.WriteLine($"Loaded SimpleGoal: {name}");
            }
            else if (goalType == "EternalGoal")
            {
              
                newGoal = new EternalGoal(name, description, points);
                Console.WriteLine($"Loaded EternalGoal: {name}");
            }
            else if (goalType == "ChecklistGoal" && parts.Length >= 6)
            {
                
                int target = int.TryParse(parts[5], out int parsedTarget) ? parsedTarget : 0;
                int bonus = int.TryParse(parts[6], out int parsedBonus) ? parsedBonus : 0;
                int completed = int.TryParse(parts[4], out int parsedCompleted) ? parsedCompleted : 0;
                newGoal = new ChecklistGoal(name, description, points, completed, target, bonus);
                Console.WriteLine($"Loaded ChecklistGoal: {name}, Target: {target}, Bonus: {bonus}");
            }
            else
            {
                Console.WriteLine($"Invalid goal type or missing data: {line}");
                continue;
            }

            if (newGoal != null)
            {
                _goals.Add(newGoal); 
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }
    else
    {
        Console.WriteLine($"File {fullPath} not found.");
    }
    Console.Clear();
}





}
