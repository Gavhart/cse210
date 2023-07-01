using System;
using System.Collections.Generic;

public abstract class Activity
{
    private DateTime _date;
    private int _duration;

    protected int Duration
    {
        get { return _duration; }
    }

    protected Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {GetType().Name} ({_duration} min) - Distance: {GetDistance():0.1} km, Speed: {GetSpeed():0.1} kph, Pace: {GetPace():0.1} min per km";
    }
}