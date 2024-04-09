// OutdoorGathering.cs
public class OutdoorGathering : Event
{
    public string WeatherForecast { get; set; }

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, string address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        WeatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}Weather Forecast: {WeatherForecast}\n";
    }
}