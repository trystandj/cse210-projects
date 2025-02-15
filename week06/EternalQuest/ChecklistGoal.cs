class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

        public ChecklistGoal(string name, string description, int points, int amountCompleted, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = amountCompleted;  
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
       _amountCompleted++;
    }

    public override bool IsComplete()
    {
      return _amountCompleted >= _target;
    }

   
    public override string GetDetailsString()
    {
        // Check if the goal is complete
        string completionStatus = IsComplete() ? " -- Completed!" : ""; // Add "Completed!" if it's complete
        
        // Build the string with the status appended if completed
        return $"{_shortName}: {_description} ({_points} points) -- Currently completed: {_amountCompleted}/{_target}{completionStatus}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }

    public int GetBonus()
    {
        return _bonus;
    }
}