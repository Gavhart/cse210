using System;
using System.Collections.Generic;

public class Swimming : Activity
{
    private int _laps;
    private const double LapLengthInKm = 50.0 / 1000;

    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * LapLengthInKm;
    }

    public override double GetSpeed()
    {
        return GetDistance() / (double) Duration * 60;
    }

    public override double GetPace()
    {
        return (double) Duration / GetDistance();
    }
}