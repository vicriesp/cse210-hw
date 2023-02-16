

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }
    public string GetWritingInformation()
    {
        return _title;
        //return $"{_title} by {studentName}";
    }
    public string GetStudentName()
    {
        return _StudentName;
    }
}