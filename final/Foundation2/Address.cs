public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public string GetStreetAddress()
    {
        return _streetAddress;
    }
    public void SetStreetAddress(string streetAddress)
    {
        _streetAddress = streetAddress;
    }
    public string GetCity()
    {
        return _city;
    }
    public void SetCity(string city)
    {
        _city = city;
    }
    public string GetState()
    {
        return _state;
    }
    public void SetState(string state)
    {
        _state = state;
    }
    public string GetCountry()
    {
        return _country;
    }
    public void SetCountry(string country)
    {
        _country = country;
    }
    public void GetAddress()
    {
        Console.WriteLine($"{_streetAddress}, {_city}, {_state}, {_country}.");
    }
    public void GetShippingCost()
    {
        Order total = new Order();
        double tTotal = total.GetPrice();

      if (_country == "USA")
      {
        double five = tTotal + 5;
        Console.WriteLine($"Total: {five}");
      }
      else if (_country != "USA")
      {
        double tF = tTotal + 35;
        Console.WriteLine($"Total: {tF}");
      }
    }
}