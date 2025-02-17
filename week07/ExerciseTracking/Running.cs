class Running : Activity
{
    private double _distance; 

    public Running(string date, int minutes, double distance)
        : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        if (_minutes == 0) 
        {
            return 0; 
        }
        return _distance / (_minutes / 60.0); 
    }

    public override double GetPace()
    {
        if (_distance == 0) 
        {
            return 0; 
        }
        return _minutes / _distance; 
    }

    public override string GetSummary() 
    {
        return $"{_date} ({_minutes} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}