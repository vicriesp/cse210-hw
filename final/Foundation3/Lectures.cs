public class Lectures : Event
{
    private string _speakerName;
    private string _capacity;

    public Lectures(string eventTitle,
    string description, string date,
    string time, string address, string typeOfEvent,
    string speakerName, string capacity
    ) :base(eventTitle, description, date, time, address, typeOfEvent)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }
    public string GetSpeakerName()
    {
        return _speakerName;
    }
    public string GetCapacity()
    {
        return _capacity;
    }
    public string GetSpeakerCapacity()
    {
        return $"Speaker: {_speakerName} \nCapacity: {_capacity}";
    }
}