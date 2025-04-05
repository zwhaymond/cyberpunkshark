using System;

public abstract class Event
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public string Time { get; set; }
    public Address EventAddress { get; set; }

    public Event(string title, string description, DateTime date, string time, Address eventAddress)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        EventAddress = eventAddress;
    }

    public virtual string StandardDetails()
    {
        return $"{Title}\n{Description}\nDate: {Date.ToShortDateString()}\nTime: {Time}\nAddress: {EventAddress}";
    }

    public abstract string FullDetails();
    public abstract string ShortDescription();
}
