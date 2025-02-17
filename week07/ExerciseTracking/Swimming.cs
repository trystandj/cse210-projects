using System;

class Swimming : Activity
{
        private double _laps; 

        public Swimming(string date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50) / 1609.34;
    }

    public override double GetSpeed()
    {
        if (_minutes == 0)
        {
            return 0;
        }
        return GetDistance() / (_minutes / 60.0);
    }

    public override double GetPace()
    {
        if (_minutes == 0 || GetDistance() == 0)
        {
            return 0;
        }
        return _minutes / GetDistance();
    }

    public override string GetSummary()
    {
       return $"{_date} ({_minutes} min) - Distance: {GetDistance():F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
    
}