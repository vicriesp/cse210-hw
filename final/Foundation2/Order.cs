public class Order
{
    private double _price1;
    private double _price2;
    private string _product1;
    private string _product2;
    private string _customer;
    private int _quantity1;
    private int _quantity2;

    public double GetPrice1()
    {
        return _price1;
    }
    public void SetPrice1(double price1)
    {
        _price1 = price1;
    }
    public double GetPrice2()
    {
        return _price2;
    }
    public void SetPrice2(double price2)
    {
        _price2 = price2;
    }
    public string GetProduct1()
    {
        return _product1;
    }
    public void SetProduct1(string product1)
    {
        _product1 = product1;
    }
    public String GetProduct2()
    {
        return _product2;
    }
    public void SetProduct2(string product2)
    {
        _product2 = product2;
    }
    public string GetCustomer()
    {
        return _customer;
    }
    public void SetCustomer(string customer)
    {
        _customer = customer;
    }
    public int GetQuantity1()
    {
        return _quantity1;
    }
    public void SetQuantity1(int quantity1)
    {
        _quantity1 = quantity1;
    }
    public int GetQuantity2()
    {
        return _quantity2;
    }
    public void SetQuantity2(int quantity2)
    {
        _quantity2 = quantity2;
    }
    public double GetPrice()
    {
        double sTotal = (_price1 * _quantity1) + (_price2 * _quantity2);
        Console.WriteLine($"SubTotal: {sTotal}");
        return sTotal;
    }
}