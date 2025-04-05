using System;

public class Running : Activity
{
    private double distance; // in miles

    public Running(DateTime date, int durationInMinutes, double distance) : base(date, durationInMinutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return (distance / durationInMinutes) * 60; // miles per hour
    }

    public override double GetPace()
    {
        return durationInMinutes / distance; // minutes per mile
    }
}
