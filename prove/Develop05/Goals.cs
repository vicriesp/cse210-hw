public class Goals
{
    protected string _goalName = "";
    protected string _goalDescription = "";
    public int _goalPoints = 0;

    

    public void getGoals()
    {
        Console.WriteLine($"[ ] {_goalName} ({_goalDescription})");
    }
} 