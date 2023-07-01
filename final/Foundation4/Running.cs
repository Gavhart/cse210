using System;
using System.Collections.Generic;

public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / (double) Duration * 60;
    }

    public override double GetPace()
    {
        return (double) Duration / _distance;
    }

}