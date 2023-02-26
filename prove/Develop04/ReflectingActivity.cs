
public class ReflectingActivity : Activity
{
    private string _refelctingList;

    public ReflectingActivity(
    string startingMessage, 
    string welcomeMessage,
    string reflectingList) 
    : base(startingMessage, 
    welcomeMessage)
    {
        _refelctingList = reflectingList;
    }
    public string GetReflectingList()
    {
        return _refelctingList;
    }
    public void GetList()
    {
    //Console.Clear();
    //Console.WriteLine("Consider the following promt:");
    Console.WriteLine(" ");
    
    string[] reflect = {
        "--Think of a time when you stood up for someone else.--",
        "--Think of a time when you did something really difficult--",
        "--Think of a time when you helped someone in need.--",
        "--Think of a time when you did something truly selfless--"
        };

    var random = new Random();
    var randomReflect = random.Next(0, reflect.Length);
    Console.WriteLine(reflect[randomReflect]);
    
    Console.WriteLine(" ");
    Console.WriteLine("When you have something in mind, press enter to continue.");
    Console.ReadLine();

    Console.WriteLine(" ");
    Console.WriteLine("How long, in seconds, would you like for your session? ");
    var seconds = Convert.ToInt32(Console.ReadLine());
    
    int secondsBreath = (seconds * 1000) / 5;
        Console.Clear();
        
        //Console.WriteLine("Get ready!");
        Console.WriteLine(" ");

        Console.WriteLine("Why was this experience meaningful to you?");
        Thread.Sleep(secondsBreath);
        Console.WriteLine(" ");
        Console.WriteLine("Have you ever done anything like this before?");
        Thread.Sleep(secondsBreath);
        Console.WriteLine(" ");
        Console.WriteLine("How did you get started?");
        Thread.Sleep(secondsBreath);
        Console.WriteLine(" ");
        Console.WriteLine("How did you feel when it was complete?");
        Thread.Sleep(secondsBreath);
        Console.WriteLine(" ");
        Console.WriteLine("What made this time different than other times when you were not as successful?");
        Thread.Sleep(secondsBreath);
        Console.WriteLine(" ");
        Console.WriteLine("What is your favorite thing about this experience?");
        Thread.Sleep(secondsBreath);
        Console.WriteLine(" ");
        Console.WriteLine("What could you learn from this experience that applies to other situations?");
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
    
    
    
    
    
    
    // string[] list = {
    //     "Why was this experience meaningful to you?", 
    //     "Have you ever done anything like this before?", 
    //     "How did you get started?", 
    //     "How did you feel when it was complete?", 
    //     "What made this time different than other times when you were not as successful?", 
    //     "What is your favorite thing about this experience?", 
    //     "What could you learn from this experience that applies to other situations?", 
    //     "What did you learn about yourself through this experience?", 
    //     "How can you keep this experience in mind in the future?"};

    // //var random = new Random();
    // var randomIndex = random.Next(0, list.Length);
    // Console.WriteLine(list[randomIndex]);
    }
}