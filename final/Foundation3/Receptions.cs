public class Receptions : Event
{
    private string _email;

    public Receptions(string eventTitle,
    string description, string date,
    string time, string address, string typeOfEvent,
    string email
    ) :base(eventTitle, description, date,
    time, address, typeOfEvent)
    {
        _email = email;
    }
    public string GetEmail()
    {
        return $"Email: {_email}";
    }
}