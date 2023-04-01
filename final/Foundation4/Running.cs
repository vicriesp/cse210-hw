public class Running : Activity
{
    
    public Running(string date, double length, double distance, double speed) : base(date, length, distance, speed)
    {
       // _distance = distance;
    }
    

    public override double CalculateDistance()
    {
        return _distance;
    }
    public override double CalculateSpeed()
    {
        return (_distance / _length) * 60;
    }
    public override double CalculatePace()
    {
        return _length / _distance;
    }
    public override string GetSummary()
    {
        return $"Distance: {CalculateDistance()}km, Speed: {CalculateSpeed()} kph, Pace: {CalculatePace()} min per km";
    }










}