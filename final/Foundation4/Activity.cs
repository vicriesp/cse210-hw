public class Activity
{
    private string _date;
    protected double _length;
    protected double _distance;
    protected double _speed;

    public Activity(string date, double length, double distance, double speed)
    {
        _date = date;
        _length = length;
        _distance = distance;
        _speed = speed;
    }    
    public string GetDate()
    {
        return _date;
    }
    public double GetLength()
    {
        return _length;
    }
    
    
    public virtual double CalculateDistance()
    {
        return _length;
    }

    public virtual double CalculateSpeed()
    {
        return _length;
    }

    public virtual double CalculatePace()
    {
        return _length;
    }

    public virtual string GetSummary()
    {
        return _date;
    }
}