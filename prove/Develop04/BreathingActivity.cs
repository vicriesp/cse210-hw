
public class BreathingActivity
{
    private string _breathInOut;

    public BreathingActivity(string breathInOut) 
    // : base(timeForSession, 
    // welcomeMessage, 
    // startingMessage)
    {
        _breathInOut = breathInOut;
    }
    public string GetBreathInOut()
    {
        return _breathInOut;
    }
    public void timeToBreath()
    {
        Console.WriteLine("How long, inseconds, would you like for your session? ");
        var seconds = Convert.ToInt32(Console.ReadLine());

        Console.Clear();
        Console.WriteLine(" ");
        Console.WriteLine("Get ready!");

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

        int secondsBreath = (seconds * 1000) / 5;
        Console.Clear();
        
        //Console.WriteLine("Get ready!");
        Console.WriteLine(" ");

        Console.WriteLine("Breath In...");
        Thread.Sleep(secondsBreath);
        //Console.WriteLine(" ");
        Console.WriteLine("Now breath Out...");
        Thread.Sleep(secondsBreath);
        Console.WriteLine(" ");
        Console.WriteLine("Breath In...");
        Thread.Sleep(secondsBreath);
        //Console.WriteLine(" ");
        Console.WriteLine("Now breath Out...");
        Thread.Sleep(secondsBreath);
        Console.WriteLine(" ");
        Console.WriteLine("Breath In...");
        Thread.Sleep(secondsBreath);
        //Console.WriteLine(" ");
        Console.WriteLine("Now breath Out...");
        Thread.Sleep(secondsBreath);
        Console.WriteLine(" ");
        Console.WriteLine("Breath In...");
        Thread.Sleep(secondsBreath);
        Console.WriteLine(" ");

        Console.Write("\rTime has finished, you did really good!!.");

        //Console.Clear();
        Console.WriteLine(" ");
        //Console.WriteLine("Get ready!");

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

        Console.WriteLine("You have completed another " + seconds + " seconds of the breathing activity");
        
        //Console.Clear();
        Console.WriteLine(" ");
        //Console.WriteLine("Get ready!");

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
        //Console.Write("\b \b");

        Console.Clear();
    }
    
}