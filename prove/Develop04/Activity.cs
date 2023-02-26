
public class Activity
{
    private string _startingMessage;
    private string _welcomeMessage;
    
    public Activity(
    string startingMessage,
    string welcomeMessage)
    {
        _startingMessage = startingMessage;
        _welcomeMessage = welcomeMessage;
    }
    public string GetStartingMessage()
    {
        return _startingMessage;
    }
    public string GetWelcomeMessage()
    {
        return _welcomeMessage;
    }
    
       
}