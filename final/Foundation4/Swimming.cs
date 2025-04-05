using System;

public class Swimming : Activity
{
    private int laps; // number of laps

    public Swimming(DateTime date, int durationInMinutes, int laps) : base(date, durationInMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return (laps * 50) / 1000.0 * 0.62; // convert laps to miles (50m per lap)
    }

    public override double GetSpeed()
    {
        double distance = GetDistance();
        return (distance / durationInMinutes) * 60; // miles per hour
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        return durationInMinutes / distance; // minutes per mile
    }
}
