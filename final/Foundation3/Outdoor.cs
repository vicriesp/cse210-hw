public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string eventTitle, string description, string date, string time, string address, string typeOfEvent,
    string weather) :base(eventTitle, description, date, time, address, typeOfEvent)
    {
        _weather = weather;
    }
    public string GetWeather()
    {
        return $"Expected Weather: {_weather}";
    }
}