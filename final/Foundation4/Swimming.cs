public class Swimming : Activity
{
    private double _numberOfLaps;

    public Swimming(string date, double length, double distance, double speed, double numberOfLaps) : base(date, length, distance, speed)
    {
       _numberOfLaps = numberOfLaps;
    }
    

    public override double CalculateDistance()
    {
        return _numberOfLaps * 50 / 1000;
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