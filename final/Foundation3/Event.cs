public class Event
{
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private string _address;
    private string _typeOfEvent;

    public Event(string eventTitle,
    string description, string date,
    string time, string address, string typeOfEvent)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _typeOfEvent = typeOfEvent;
    }
    public string GetEventTitle()
    {
        return _eventTitle;
    }
    public void SetEventTitle(string eventTitle)
    {
        _eventTitle = eventTitle;
    }
    public string GetDescription()
    {
        return _description;
    }
    public string GetDate()
    {
        return _date;
    }
    public string GetTime()
    {
        return _time;
    }
    public string GetAddress()
    {
        return _address;
    }
    public string GetTypeOfEvent()
    {
        return _typeOfEvent;
    }
    public string GetSumary()
    {
        return $"Event: {_eventTitle}, Description: {_description}, Date: {_date}, Time: {_time}, Address: {_address}";
    }
    public string GetShortDetails()
    {
        return $"Event: {_typeOfEvent}, Title: {_eventTitle}, Date: {_date}, Time: {_time}.";
    }
}