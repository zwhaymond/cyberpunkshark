using System;

public class Lecture : Event
{
    public string Speaker { get; set; }
    public int Capacity { get; set; }

    public Lecture(string title, string description, DateTime date, string time, Address eventAddress, string speaker, int capacity)
        : base(title, description, date, time, eventAddress)
    {
        Speaker = speaker;
        Capacity = capacity;
    }

    public override string FullDetails()
    {
        return $"{StandardDetails()}\nEvent Type: Lecture\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }

    public override string ShortDescription()
    {
        return $"Lecture: {Title}\nDate: {Date.ToShortDateString()}";
    }
}
