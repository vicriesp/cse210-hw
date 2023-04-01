public class Cycling : Activity
{
    

    public Cycling(string date, double length, double distance, double speed) : base(date, length, distance, speed)
    {
        //_speed = Speed;
    }


    public override double CalculateDistance()
    {
        return _speed;
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