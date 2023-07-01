using System;
using System.Collections.Generic;

public class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public string WeatherForecast
    {
        get { return _weatherForecast; }
        set { _weatherForecast = value; }
    }

    public override string GetFullDetails()
    {
        string baseDetails = GetStandardDetails();
        return $"{baseDetails}\nType: Outdoor Gathering\nWeather Forecast: {_weatherForecast}";
    }
}