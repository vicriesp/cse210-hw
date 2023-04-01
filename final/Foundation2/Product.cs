public class Product
{
    private string _product1;
    private string _product2;
    private string _productId1;
    private string _productId2;
    private double _price;
    

    public string GetProduct1()
    {
        return _product1;
    }
    public void SetProduct1(string product1)
    {
        _product1 = product1;
    }
    public string GetProduct2()
    {
        return _product2;
    }
    public void SetProduct2(string product2)
    {
        _product2 = product2;
    }
    public string GetProductId1()
    {
        return _productId1;
    }
    public void SetProductId1(string productId1)
    {
        _productId1 = productId1;
    }
    public string GetProductId2()
    {
        return _productId2;
    }
    public void SetProductId2(string productId2)
    {
        _productId2 = productId2;
    }
    public double GetPrice()
    {
        return _price;
    }
    public void SetPrice(double price)
    {
        _price = price;
    }
    
    public void GetPackingLabel()
    {
    Console.Write(" ");
    Console.Write(" ");
    Console.WriteLine(" Packaging Label:");
    Console.WriteLine($"Product: {_product1} ID: {_productId1} \nProduct: {_product2} ID: {_productId2}");
    Console.WriteLine(" ");
    }
}