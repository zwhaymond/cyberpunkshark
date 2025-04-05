using System;

public class OutdoorGathering : Event
{
    public string WeatherForecast { get; set; }

    public OutdoorGathering(string title, string description, DateTime date, string time, Address eventAddress, string weatherForecast)
        : base(title, description, date, time, eventAddress)
    {
        WeatherForecast = weatherForecast;
    }

    public override string FullDetails()
    {
        return $"{StandardDetails()}\nEvent Type: Outdoor Gathering\nWeather Forecast: {WeatherForecast}";
    }

    public override string ShortDescription()
    {
        return $"Outdoor Gathering: {Title}\nDate: {Date.ToShortDateString()}";
    }
}
