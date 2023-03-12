using System.IO;

public class ListGoals
{
    public List<Goals> _goals = new List<Goals>();

    public void displayGoals()
    {
        foreach (Goals goal in _goals)
        {
            goal.getGoals();
            
        }

        
    }
}