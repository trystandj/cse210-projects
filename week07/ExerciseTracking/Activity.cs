using System;
using System.Runtime.InteropServices;

abstract class Activity
{
    protected string _date;
    protected int _minutes;

    public Activity(string date, int minutes){
        _date = date;
        _minutes = minutes;
    }

    public abstract string GetSummary();

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();


}

