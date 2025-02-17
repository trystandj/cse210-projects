using System;

class Bicycles : Activity
{
        private double _speed; 
        public Bicycles(string date, int minutes, int speed)
        : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
         return _speed * (_minutes / 60.0);
    }

    public override double GetSpeed()
    {
        if (_minutes == 0) 
        {
            return 0; 
        }
        return _speed;
    }
    public override double GetPace()
    {
        if (_speed == 0) 
        {
            return 0; 
        }
        return 60 / _speed;
    }

    public override string RecordEvent()
    {
        return $"{_date} ({_minutes} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}