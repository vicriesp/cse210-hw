
public class Assignment
{
    protected string _StudentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _StudentName = studentName;
        _topic = topic;
    }
    public string GetSummaryName()
    {
        return _StudentName;
    }
    public string GetSummaryTopic()
    {
        return _topic;
    }
}