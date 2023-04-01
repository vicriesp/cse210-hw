using System;

class Program
{
    static void Main(string[] args)
    {

        Product product1 = new Product();
        product1.SetProduct1("Avocado");
        product1.SetProduct2("Carrot");
        product1.SetProductId1("QW01");
        product1.SetProductId2("QW09");
        Console.WriteLine(" ");
        product1.GetPackingLabel();
        

        Customer customer1 = new Customer();
        customer1.SetName("Juan W.");
        Console.WriteLine(" Shipping Label:");
        Console.WriteLine(customer1.GetName());
        
        Address address1 = new Address();
        address1.SetStreetAddress("Av. Montes");
        address1.SetCity("Provo");
        address1.SetState("Utah");
        address1.SetCountry("USA");

        address1.GetAddress();
        Console.WriteLine(" ");

        Order order1 = new Order();
        order1.SetCustomer("Juan W.");
        order1.SetPrice1(3);
        order1.SetPrice2(5);
        order1.SetQuantity1(4);
        order1.SetQuantity2(2);

        order1.GetPrice();
        Console.WriteLine("******************************");

        Product product2 = new Product();
        product2.SetProduct1("Apples");
        product2.SetProduct2("Banana");
        product2.SetProductId1("QW10");
        product2.SetProductId2("QW11");
        Console.WriteLine(" ");
        product2.GetPackingLabel();

        Customer customer2 = new Customer();
        customer2.SetName("Abelt A.");
        Console.WriteLine(" Shipping Label:");
        Console.WriteLine(customer2.GetName());
        
        Address address2 = new Address();
        address2.SetStreetAddress("Pacific Road #12");
        address2.SetCity("Ontario");
        address2.SetState("Toronto");
        address2.SetCountry("Canada");

        address2.GetAddress();
        Console.WriteLine(" ");

        Order order2 = new Order();
        order2.SetPrice1(4);
        order2.SetPrice2(2);
        order2.SetQuantity1(5);
        order2.SetQuantity2(10);

        order2.GetPrice();
        Console.WriteLine("******************************");

    }
}