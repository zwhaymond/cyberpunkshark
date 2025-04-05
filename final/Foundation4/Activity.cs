using System;

public abstract class Activity
{
    protected DateTime date;
    protected int durationInMinutes;

    public Activity(DateTime date, int durationInMinutes)
    {
        this.date = date;
        this.durationInMinutes = durationInMinutes;
    }

    public abstract double GetDistance(); // Virtual method to be overridden in derived classes
    public abstract double GetSpeed();    // Virtual method to be overridden in derived classes
    public abstract double GetPace();     // Virtual method to be overridden in derived classes

    public string GetSummary()
    {
        return $"{date:dd MMM yyyy} {this.GetType().Name} ({durationInMinutes} min): " +
               $"Distance {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}
