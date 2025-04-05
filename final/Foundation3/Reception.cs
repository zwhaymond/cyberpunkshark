using System;

public class Reception : Event
{
    public string RsvpEmail { get; set; }

    public Reception(string title, string description, DateTime date, string time, Address eventAddress, string rsvpEmail)
        : base(title, description, date, time, eventAddress)
    {
        RsvpEmail = rsvpEmail;
    }

    public override string FullDetails()
    {
        return $"{StandardDetails()}\nEvent Type: Reception\nRSVP Email: {RsvpEmail}";
    }

    public override string ShortDescription()
    {
        return $"Reception: {Title}\nDate: {Date.ToShortDateString()}";
    }
}
