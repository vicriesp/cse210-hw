public class Customer
{
    private string _name;
    private string _address;

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetAddress()
    {
        return _address;
    }
    public void SetAddress(string address)
    {
        _address = address;
    }
    public void GetShippingLabel()
    {
        Console.Write(" ");
        Console.WriteLine("Shipping Label:");
        Console.WriteLine($"Name: {_name} \nAddress: {_address}");
        Console.WriteLine(" ");
    }
}