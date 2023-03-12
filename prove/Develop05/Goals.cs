public class Goals
{
    protected string _goalName = "";
    protected string _goalDescription = "";
    public int _goalPoints = 0;

    // public Goals(string goalName, string goalDescription)
    // {
    //     _goalName = goalName;
    //     _goalDescription = goalDescription;
    // }

    public void getGoals()
    {
        Console.WriteLine($"[ ] {_goalName} ({_goalDescription})");
    }
} 