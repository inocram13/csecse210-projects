using System;
using System.Collections.Generic;

public abstract class Activity
{
    private DateTime _date;
    private int _lengthInMinutes; 

    protected Activity(DateTime date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    protected int LengthInMinutes => _lengthInMinutes;
    protected DateTime Date => _date;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetType().Name} ({_lengthInMinutes} min): " +
               $"Distance: {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min/km";
    }
}
