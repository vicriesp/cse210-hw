public class Product
{
    private string _product1;
    private string _product2;
    private string _productId1;
    private string _productId2;
    private double _price;
    // private int _quantity1;
    // private int _quantity2;

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
    // public int GetQuantity1()
    // {
    //     return _quantity1;
    // }
    // public void SetQuantity1(int quantity1)
    // {
    //     _quantity1 = quantity1;
    // }
    // public int GetQuantity2()
    // {
    //     return _quantity2;
    // }
    // public void SetQuantity2(int quantity2)
    // {
    //     _quantity2 = quantity2;
    // }
    public void GetPackingLabel()
    {
    //Console.Clear();
    Console.Write(" ");
    Console.Write(" ");
    Console.WriteLine(" Packaging Label:");
    Console.WriteLine($"Product: {_product1} ID: {_productId1} \nProduct: {_product2} ID: {_productId2}");
    Console.WriteLine(" ");
    }
    // public double GetSubTotal()
    // {
    //     // double total = (_price1 + _price2) * (_quantity1 + _quantity2);
    //     // return total;
    // }
}