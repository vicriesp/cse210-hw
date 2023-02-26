
public class ListingActivity : Activity
{
    private string _instructions;

    public ListingActivity(
    string startingMessage, 
    string welcomeMessage,
    string instructions) 
    : base(startingMessage, 
    welcomeMessage)
    {
        _instructions = instructions;
    }
    public string GetInstructions()
    {
        return _instructions;
    }
    public void GetSpinerAnimation()
    {
        Console.WriteLine(" ");
        Console.Write("Press enter to start.");
        Console.ReadLine();
    
        
        Console.Clear();
        Console.Write("Get ready.");
        
        Console.WriteLine(" ");
        Console.Write(".");
        Thread.Sleep(1000);
        Console.Write("\b \b");

        Console.Write(" .");
        Thread.Sleep(1000);
        Console.Write("\b \b");

        Console.Write("  .");
        Thread.Sleep(1000);
        Console.Write("\b \b");

        Console.Write(".");
        Thread.Sleep(1000);
        Console.Write("\b \b");

        Console.Write(" .");
        Thread.Sleep(1000);
        Console.Write("\b \b");

        Console.Write("  .");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.WriteLine(" ");

    }
    public void GetListResponses()
    {
        Console.WriteLine("List 5 responses to the following prompt:");

        string[] list = {
        "--Who are people that you appreciate?--", 
        "--What are personal strengths of yours?--", 
        "--Who are people that you have helped this week?--", 
        "--When have you felt the Holy Ghost this month?--", 
        "--Who are some of your personal heroes?--"};
        
        Console.WriteLine(" ");
        var random = new Random();
        var randomIndex = random.Next(0, list.Length);
        Console.WriteLine(list[randomIndex]);

        Console.WriteLine(" ");
        Console.Write("< ");
        Console.ReadLine();

        Console.WriteLine(" ");
        Console.Write("< ");
        Console.ReadLine();

        Console.WriteLine(" ");
        Console.Write("< ");
        Console.ReadLine();

        Console.WriteLine(" ");
        Console.Write("< ");
        Console.ReadLine();

        Console.WriteLine(" ");
        Console.Write("< ");
        Console.ReadLine();

        Console.WriteLine(" ");
        Console.WriteLine("Thank you for the responses, you did it really good!");
    }
    public void GetEnd()
    {
        
        Console.WriteLine(" ");
        Console.Write(".");
        Thread.Sleep(1000);
        Console.Write("\b \b");

        Console.Write(" .");
        Thread.Sleep(1000);
        Console.Write("\b \b");

        Console.Write("  .");
        Thread.Sleep(1000);
        Console.Write("\b \b");

        Console.Write(".");
        Thread.Sleep(1000);
        Console.Write("\b \b");

        Console.Write(" .");
        Thread.Sleep(1000);
        Console.Write("\b \b");

        Console.Write("  .");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.WriteLine(" ");
        Console.Clear();

        Console.WriteLine("You have completed another listing activity");
        
        Console.WriteLine(" ");
        Console.Write(".");
        Thread.Sleep(1000);
        Console.Write("\b \b");

        Console.Write(" .");
        Thread.Sleep(1000);
        Console.Write("\b \b");

        Console.Write("  .");
        Thread.Sleep(1000);
        Console.Write("\b \b");

        Console.Write(".");
        Thread.Sleep(1000);
        Console.Write("\b \b");

        Console.Write(" .");
        Thread.Sleep(1000);
        Console.Write("\b \b");

        Console.Write("  .");
        Thread.Sleep(1000);
        Console.Write("\b \b");

        Console.Clear();
    }
}