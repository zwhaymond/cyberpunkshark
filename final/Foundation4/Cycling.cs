using System;

public class Cycling : Activity
{
    private double speed; // in miles per hour

    public Cycling(DateTime date, int durationInMinutes, double speed) : base(date, durationInMinutes)
    {
        this.speed = speed;
    }

    public override double GetDistance()
    {
        return (speed / 60) * durationInMinutes; // distance = speed * time
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60 / speed; // minutes per mile
    }
}
